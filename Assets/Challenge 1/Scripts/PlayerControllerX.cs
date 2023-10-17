using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float horizontalInput;
    public float forwardInput;
    public float turnSpeed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame 
    void FixedUpdate()
    {
        //assgins the forward input from the keyboard to forwardInput
        forwardInput = Input.GetAxis("Vertical");

        //makes the plane rotate off the the Z coord smoothly and at rotationSpeed speed and only executes if forward input is given
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed *  forwardInput);

        //makes the plane fly at a constant speed smoothly
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
