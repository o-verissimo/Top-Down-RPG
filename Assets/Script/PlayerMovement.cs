using UnityEngine;

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
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0.002f, 0);
        }


    }

}
