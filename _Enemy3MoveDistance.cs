using JetBrains.Annotations;
using NUnit.Framework.Constraints;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy3MoveDistance : MonoBehaviour
{
    public Transform station;
    public GameObject enemy;
    public Transform enemyPos;
    public GameObject energyBallPrefab;
    public Transform firePoint2;
    

    public Vector2 enemyStationDistance;
    public Vector3 enemy1Location;
    public float enemySpeed1;
    public float energyBallSpeed = 100f;
    public bool shootButton = true; 

    void Start()
    {
        if (enemyPos.position.x < 0)
        {

            //flip direction of energy ball shooting
            firePoint2.Rotate(new Vector3(0, 0, 180));
            firePoint2.Translate(new Vector3(0, 1.5f, 0));


            // flip sprite of energy ball shooting
            GetComponent<SpriteRenderer>().flipX = true;
        }


    }
    //Collision, destruction of enemy and score
    void OnCollisionEnter2D(Collision2D collision)
    {


        scoreScript.scoreValue += 10;
        Destroy(gameObject);




    }

    public IEnumerator ShootEnergyBall()
    {
        yield return new WaitForSeconds(1f);

            GameObject energyBall2 = Instantiate(energyBallPrefab, firePoint2.position, firePoint2.rotation);
            Rigidbody2D energyBallPrefabRB = energyBall2.GetComponent<Rigidbody2D>();
            energyBallPrefabRB.AddForce(firePoint2.up * 30f);
    }
    // Update is called once per frame
  
    void Update()
    {
       

        var enemyStationDistance = Vector2.Distance(enemyPos.position, station.position);
        
        if (enemyStationDistance < 6 & shootButton == true)
        {
            
           
            
             StartCoroutine(ShootEnergyBall());
            shootButton = false;

        }


        if (enemyStationDistance > 6)
        {
            enemyPos.position = Vector3.MoveTowards(enemyPos.position, station.position, Time.deltaTime * enemySpeed1);
            


        }
        



        enemyPos.position = enemyPos.position + new Vector3(0, (Mathf.Sin(Time.time) / 500), 0);

        Vector3 relativePos = station.transform.position - enemyPos.transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        rotation.x = enemyPos.transform.rotation.x;
        rotation.y = enemyPos.transform.rotation.y;
        enemyPos.transform.rotation = rotation;

        

       
    
    
    
    }




}

