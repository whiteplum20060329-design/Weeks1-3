using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class controler : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public SpriteRenderer sprite;
    public Color startingColour;
    public Camera gameCamera;


    public List<SpriteRenderer> controllableRenderers;
    public List<Transform> controlledTransforms;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        sprite.color = startingColour;
        bool isInsideSprite = sprite.bounds.Contains(transform.position);

        controlledTransforms.Add(transform);
    }


//Update is called once per frame
void Update()
{

Vector3 currentMousePosition= Mouse.current.position.ReadValue();

Vector3 worldMouse = gameCamera.ScreenToWorldPoint(currentMousePosition);

worldMouse.z = 0;

    bool left = Mouse.current.leftButton.isPressed;

        if (left)
        {
            //Find any renderers that are currently hovered over
            for (int i = 0; i < controllableRenderers.Count; i++)
            {
                SpriteRenderer currentSpriteRenderer = controllableRenderers[i];
                bool isHovered = currentSpriteRenderer.bounds.Contains(worldMouse);
                if (isHovered)
                {
                    controlledTransforms.Add(currentSpriteRenderer.transform);
                }
            }
        }

        for (int i = 0; i < controlledTransforms.Count;i ++)
        {
            Transform currentTransform = controlledTransforms[i];
            bool goleft = Keyboard.current.leftArrowKey.isPressed;
            if (goleft)
            {
                transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;

            }
            bool goright = Keyboard.current.rightArrowKey.isPressed;
            if (goright)
            {
                transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;
            }



            bool goup = Keyboard.current.upArrowKey.isPressed;
            if (goup)
            {
                transform.position += transform.up * speed * Time.deltaTime;
            }
            bool godown = Keyboard.current.downArrowKey.isPressed;
            if (godown)
            {
                transform.position -= transform.up * speed * Time.deltaTime;
            }

        }




    

    }
}
