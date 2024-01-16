using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_at_mouse : MonoBehaviour
{
    void LateUpdate()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y).normalized;
        transform.up = direction;
    }
}
