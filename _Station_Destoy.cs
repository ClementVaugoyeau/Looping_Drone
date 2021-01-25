using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;



public class Station_Destoy : MonoBehaviour
{




    public GameObject Station;
    public GameObject bigHitEffect;
    public bool collisionO = false;
    public AudioSource StationExplosion;

    private void Start()
    {
       
    }

     void Update()
    {
       
        Invoke("ChangeSceneToVictory", 35f);

    }
    public void ChangeSceneToVictory()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void ChangeSceneToRetry()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(bigHitEffect, transform.position, Quaternion.identity);
        
        StationExplosion.Play();
       
        Destroy(effect, 2.75f);
        

        Invoke("ChangeSceneToRetry", 2.75f);

       
       
        
        

        



    }

    
    
 }
