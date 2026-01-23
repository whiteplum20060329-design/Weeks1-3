using UnityEngine;
using UnityEngine.InputSystem;

public class mousefollow  : MonoBehaviour
{
    public Camera gamecamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();

        Vector3 worldMousePositon =  gamecamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePositon.z = 0;
        transform.position = worldMousePositon;



    }
}
