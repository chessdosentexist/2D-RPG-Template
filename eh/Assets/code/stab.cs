using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stab : MonoBehaviour
{
    public float damage;
    public GameObject player;
    public GameObject self;
    private void Awake()
    {
        player = GameObject.Find("Good Guy");
    }

    void Update()
    {
        if (new Vector2(self.transform.position.x-player.transform.position.x, self.transform.position.y - player.transform.position.y).magnitude <= 0.5f)
        {
            player.GetComponent<HealthCalculations>().take_damage(damage);
        }
    }
}
