using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawEnemyPoint : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawnPoint;


    void Start()
    {
        GameObject _enemy = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        
        
       
       



    }


}
