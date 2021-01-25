using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Framerate : MonoBehaviour
{
    void Start()
    {
        // Make the game run as 60 fps
        Application.targetFrameRate = 60;
    }

}
