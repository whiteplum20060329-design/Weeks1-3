using UnityEngine;
using UnityEngine.InputSystem;

public class flower : MonoBehaviour
{

    public float Distance;
    public Camera gameCamera;

    public AnimationCurve curve;
    public float duration;
    public float output;

    private float progress = 0;

    Vector3 baseScale;
    public float startScale = 0.1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        baseScale = transform.localScale;//This variable stores the object¡¯s normal size,
                                         //which helps prevent the scale from becoming too large during later transformations.
        transform.localScale = baseScale * startScale;//This is used to make the object start off very small,
                                                      //and then only begin scaling once the animation is activated.
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = Mouse.current.position.ReadValue();
        Vector3 worldMouse = gameCamera.ScreenToWorldPoint(MousePos);    // Convert the mouse position from screen space to world space.
        // This allows to distance the mouse position with the flower's position.
        worldMouse.z = 0;


        float distanceToMouse = Vector3.Distance(worldMouse, transform.position);  // Calculate the distance between the mouse and the flower.
        // This distance will be used to determine whether the animation should play.

        Debug.Log("Distance is" + distanceToMouse);
        // Print the distance to the console for debugging purposes.

        if (distanceToMouse < Distance)
        // If the mouse is close enough to the flower,
        // the scaling animation will be triggered.
        // This creates an effect similar to watering a flower with the mouse,
        // causing it to bloom when the mouse approaches.
        {
            progress += Time.deltaTime / duration;
            // Increase the progress value over time.
            // This moves the animation forward along the curve.
            output = curve.Evaluate(progress);
            // Evaluate the animation curve using the current progress value.
            // The result controls how large the flower becomes.
            transform.localScale = baseScale * output;
            // Apply the scale using the base scale and curve output.
            // Using baseScale ensures the size stays within a reasonable range.

            if (progress > 1f)
            // Reset the progress value when it exceeds 1,
            // allowing the animation to loop.
            {
                progress = 0f;
            }
        }


    }
}
