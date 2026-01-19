using UnityEngine;

public class duckmove : MonoBehaviour
{
    public Vector3 speed;
    public Camera gamecamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mover = transform.position;
        mover = mover + speed * Time.deltaTime;
        transform.position = mover;

        Vector3 screenTransformPosition = gamecamera.WorldToScreenPoint(transform.position);

        if (screenTransformPosition.x > Screen.width)
        {
            speed.x *= -1;

        }
        if (screenTransformPosition.x < 0)
        {
            speed.x *= -1;
        }
        if (screenTransformPosition.y > Screen.height)
        {
            speed.y *= -1;


        }
        if (screenTransformPosition.y < 0)
        {
            speed.y *= -1;
        }
    }
}