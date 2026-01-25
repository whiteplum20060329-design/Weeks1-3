using UnityEngine;
using UnityEngine.InputSystem;

public class tankmover : MonoBehaviour
{
    public float speed;
    public float xmin, xmax;
    public Camera gamecamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool leftArrowHeld = Keyboard.current.leftArrowKey.isPressed;
        bool rightArrowHeld = Keyboard.current.rightArrowKey.isPressed;

        if (leftArrowHeld)
        {
            transform.position -= transform.right* speed * Time.deltaTime;
        }
        if (rightArrowHeld)
        {
            transform.position += transform.right* speed * Time.deltaTime;
        }


       

        Vector3 screenTransformPosition = gamecamera.WorldToScreenPoint(transform.position);
        xmax = Screen.width;
         
        //set xMin to wherever is too far to the left for the player to see
        xmin = 0;

        if (screenTransformPosition.x > xmax)
        {
            speed = speed * -1;

        }
        else if (screenTransformPosition.x < xmin)
        {
            speed = speed * -1;
        }
    }
}
