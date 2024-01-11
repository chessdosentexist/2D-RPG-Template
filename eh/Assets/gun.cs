using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bullet;
    public float fire_rate;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (fire_rate <= 0)
            {
                Instantiate(bullet, transform.position, transform.rotation);
                fire_rate = 0.25f;
            }
        }
        fire_rate -= Time.deltaTime;
    }
}
