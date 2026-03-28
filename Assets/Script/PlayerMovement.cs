using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WASDMove();
    }

    void WASDMove()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            transform.position += new Vector3(0, 0.002f, 0);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            transform.position += new Vector3(0, -0.002f, 0);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            transform.position += new Vector3(-0.002f, 0, 0);
        }

        if (Keyboard.current.dKey.isPressed)
        {
            transform.position += new Vector3(0.002f, 0, 0);
        }


    }

}
