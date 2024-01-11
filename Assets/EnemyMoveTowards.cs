using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveTowards : MonoBehaviour 
{

    public GameObject GoodGuy;
    public float speed = 1f;
    Vector3 enemyPosition;

    // Use this for initialization
    void Start () 
    {

    }


    // Update is called once per frame
    void Update() 
    {


        //Vector3.MoveTowards(player.transform.position.x, player.transform.position.y, player.transform.position.z, 1);
        enemyPosition = Vector3.MoveTowards(transform.position, GoodGuy.transform.position, speed * Time.deltaTime);

        transform.position = enemyPosition;
   
    }
}