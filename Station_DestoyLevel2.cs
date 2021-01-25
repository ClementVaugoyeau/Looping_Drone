using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;



public class Station_DestroyLevel2 : MonoBehaviour
{




    public GameObject Station;
    public GameObject bigHitEffect;
    public bool collisionO = false;

    private void Start()
    {
       
    }

     void Update()
    {
       
        Invoke("ChangeSceneToVictory", 40f);

    }
    public void ChangeSceneToVictory()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void ChangeSceneToRetry()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 0);
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(bigHitEffect, transform.position, Quaternion.identity);

        Destroy(effect, 1f);


        Invoke("ChangeSceneToRetry", 1);

       
       
        
        

        



    }

    
    
 }
