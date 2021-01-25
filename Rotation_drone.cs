using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_drone : MonoBehaviour
{
    public Transform rotationTool;
    public bool stationPowerOff;
    public float speedRotateDrone = -0.4f;

    private void Start()
    {
        stationPowerOff = false;
    }

    void Update()
    {

        if (stationPowerOff == true)
        {
            speedRotateDrone = 0f;
            StartCoroutine(StopDroneRotation());
        
        }
            transform.Rotate(new Vector3(0f, 0f, speedRotateDrone));
        

    
    }
    public IEnumerator StopDroneRotation()
    {
        yield return new WaitForSeconds(1f);
        speedRotateDrone = -2f;
        stationPowerOff = false;
    }








}
