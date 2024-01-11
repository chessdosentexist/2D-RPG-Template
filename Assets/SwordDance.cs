using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float autospeed = 1f;
    public float rotatespeed = 100000000000000000000f;
    public float xRange = 9.5f;
    public float yRange = 4.4f;


    // Update is called once per frame
    void Update()
    {
    {
        verticalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.up * horizontalInput * Time.deltaTime * speed);
        //transform.localRotation = Quaternion.Euler(0, 0, horizontalInput * Time.deltaTime * -rotatespeed);

    }
    {
        horizontalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * speed);
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

        /*if (Input.GetButton("Horizontal"))
        {
            transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
            //transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetButton("Vertical"))
        {
            transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
            //transform.rotation = Quaternion.Euler(180, 0, 0);
        }*/
        /*if (Input.GetKeyDown("Up Arrow"))
        {
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }
        if (Input.GetKeyDown("Down Arrow"))
        {
            transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        }
        if (Input.GetKeyDown("Left Arrow"))
        {
            transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        }
        if (Input.GetKeyDown("Right Arrow"))
        {
            transform.Translate(Vector3.right * Time.deltaTime, Space.World);
        }*/
    transform.Translate(Vector2.up * Time.deltaTime * autospeed);
    /*if (Input.GetKeyDown("left shift"))
    {
        transform.Translate(Vector2.up * Time.deltaTime * autospeed);
    }*/ /**********/

    }


}
//if (Input.GetKeyDown(""))
//transform.Rotate(Vector2.up, turnSpeed * Time.deltaTime);