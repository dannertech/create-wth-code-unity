using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float turnSpeed = 45.0f;
    private float spped = 20.0f;
    private float forwardInput;
    public GameObject mainCamera;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * turnSpeed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        //get camera to follow car
        mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z + 20);
    }
}
