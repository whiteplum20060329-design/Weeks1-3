using UnityEngine;
using UnityEngine.InputSystem;

public class locker : MonoBehaviour
{
    public float rotationSpeed;
    public float Zmin;
    public float Zmax;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()


    {
        //Vector3 currentRotation = transform.eulerAngles;

        //currentRotation.z += rotationSpeed* Time.deltaTime;

        //transform.eulerAngles = currentRotation;

        //Debug.Log(transform.eulerAngles);

        //if(currentRotation.z> Zmax)
        //{
        //    rotationSpeed= rotationSpeed * -1;

        //}
        //if (currentRotation.z  < Zmin)
        //{
        //    rotationSpeed= rotationSpeed * -1;
        //}

       Vector3 currentMousePosition= Mouse.current.position.ReadValue();

        Vector3 worldMouse = gameCamera.ScreenToWorldPoint(currentMousePosition);

        worldMouse.z = 0;

        transform.up = worldMouse- transform.position;
        transform.position += transform.up * 1f * Time.deltaTime;




    }
}
