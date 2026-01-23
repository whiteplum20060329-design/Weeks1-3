using UnityEngine;
using UnityEngine.InputSystem;

public class mouse : MonoBehaviour
{
    public Camera gamecam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Mouse.current.position.ReadValue();//get the pos of the mouse on the screen first.

        Vector2 worldMouse = gamecam.ScreenToWorldPoint(MousePos);//Because the object is in the world pos,
                                                                  //the screen pos should be converted into world pos.
     

        transform.position = worldMouse;//After the conversion is completed, assign the pos to the transform.pos of the object.

    }
}
