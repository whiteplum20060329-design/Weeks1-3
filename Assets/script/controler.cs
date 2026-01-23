using UnityEngine;
using UnityEngine.InputSystem;

public class controler : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

        

        bool left = Keyboard.current.leftArrowKey.isPressed;
        if (left)
        {
            transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;

        }
        bool right = Keyboard.current.rightArrowKey.isPressed;
        if (right)
        {
            transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;
        }



        bool up= Keyboard.current.upArrowKey.isPressed;
        if (up)
        {
            transform.position+=transform.up* speed * Time.deltaTime;
        }
        bool down = Keyboard.current.downArrowKey.isPressed;
        if (down)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }

      
    }
}
