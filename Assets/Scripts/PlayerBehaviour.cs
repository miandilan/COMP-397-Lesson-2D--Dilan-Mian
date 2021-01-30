using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame - once every 16.6666ms
    //1000ms for each second
    //approximately updates 60 times per second = 60fps
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //move to the right
            rigidBody.AddForce(new Vector3(1.0f,0,0) * movementForce);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //move to the left
            rigidBody.AddForce(new Vector3(-1.0f,0,0) * movementForce);
        }
    }
}
