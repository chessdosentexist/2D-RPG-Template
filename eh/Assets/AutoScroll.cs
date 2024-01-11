using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroll : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    //public float speed = 10f;
    public float autospeed = 1f;
    public float rotatespeed = 0.00000001f;
    public float xRange = 9.5f;
    public float yRange = 4.4f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    {
        verticalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.up * horizontalInput * Time.deltaTime * speed);
        //transform.localRotation = Quaternion.Euler(0, 0, horizontalInput * Time.deltaTime * -rotatespeed);

    }
    {
        horizontalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);
        transform.localRotation = Quaternion.Euler(0, 0, verticalInput * Time.deltaTime * -rotatespeed);

    }
    if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector2.up * Time.deltaTime * autospeed);
    }
}
