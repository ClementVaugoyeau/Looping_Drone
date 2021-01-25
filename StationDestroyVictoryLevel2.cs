using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class StationDestroyVictoryLevel2 : MonoBehaviour
{
    public GameObject Station;
    public GameObject bigHitEffect;
    public bool collisionO = false;
    public float levelTime = 65;
    public AudioSource StationExplosion;
    private void Start()
    {

    }

    void Update()
    {

        Invoke("ChangeSceneToVictory", levelTime);

    }
    public void ChangeSceneToVictory()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void ChangeSceneToRetry()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(bigHitEffect, transform.position, Quaternion.identity);
        StationExplosion.Play();
        Destroy(effect, 10f);


        Invoke("ChangeSceneToRetry", 5f);










    }
}
