using UnityEngine;
using UnityEngine.InputSystem;

public class bee : MonoBehaviour
{
    public Transform startValue;
    public Vector3 endValue;
    public Transform outValue;

    public Vector3 output;
    public float t = 0f;
    public AnimationCurve curve;

    public Camera gameCamera;
    public float Distance;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = Mouse.current.position.ReadValue();
        endValue = gameCamera.ScreenToWorldPoint(MousePos);
        endValue.z = 0;
        float distanceToMouse = Vector3.Distance(startValue.position, endValue);

        if (distanceToMouse < Distance)    // If the mouse is close enough to the flower,
        // the scaling animation will be triggered.
        {


            t += Time.deltaTime;
            // Increase time value to drive the animation

            if (t > 1f)  // Reset t so the animation can loop
            {
                t = 0f;
            }


            // Interpolate between the mouse position and the target position
            // The animation curve is used to make the movement feel more natural
            output = Vector3.Lerp(startValue.position, endValue, curve.Evaluate(t));
            transform.position = output;
        }
        else
        {    // If the mouse is too far away, move the bee off screen
            // This hides the bee when it is not interacting with the player
            transform.position = outValue.position;
        }

    }
}

