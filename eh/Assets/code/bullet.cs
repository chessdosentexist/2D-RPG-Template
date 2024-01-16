using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float damage;
    // Start is called before the first frame update
    void Awake()
    {
        rb.velocity = new Vector2(transform.up.x, transform.up.y) * speed;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<HealthCalculations>() != null)
        {
            other.gameObject.GetComponent<HealthCalculations>().take_damage(damage);
        }
        Destroy(gameObject);
    }
}
