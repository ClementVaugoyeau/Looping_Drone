using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_rotation : MonoBehaviour
{
    // The target marker.
    public Transform target;
    public Transform enemy;

    // Angular speed in radians per sec.
    public float speed = 1.0f;

    void Update()
    {
        Vector3 relativePos = target.transform.position - enemy.transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        rotation.x = enemy.transform.rotation.x;
        rotation.y = enemy.transform.rotation.y;
        enemy.transform.rotation = rotation;


    }
}
