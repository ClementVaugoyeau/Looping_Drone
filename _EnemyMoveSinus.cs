using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using System;

public class EnemyMoveSinus : MonoBehaviour
{
    public Transform station;
    public GameObject enemy;
    public Transform enemyPos;
   

    public Vector3 enemy1Location;
    public float enemySpeed1;
    public int sinYVariation = 1;


    void Start()
    {
     
        

        
    }
    //Collision, destruction of enemy and score
    void OnCollisionEnter2D(Collision2D collision)
    {
        scoreScript.scoreValue += 10;

        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        enemyPos.position = Vector3.MoveTowards(enemyPos.position, station.position, Time.deltaTime * enemySpeed1);

        
        enemyPos.position = enemyPos.position + new Vector3(0, (Mathf.Sin(Time.time)/50), 0);

     
       
        
        
        Vector3 relativePos = station.transform.position - enemyPos.transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        rotation.x = enemyPos.transform.rotation.x;
        rotation.y = enemyPos.transform.rotation.y;
        enemyPos.transform.rotation = rotation;



        // Reverse sprite for enemy who has a  -x position 
        if (enemyPos.position.x < 0)
        {

            GetComponent<SpriteRenderer>().flipX = true;
        }





    }
}
