using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cameracount : MonoBehaviour
{
    void Start()
    {
        ScoreTextScript.cameraAmount = 0;
    }
    void OnTriggerEnter2D(Collider2D col)
   {
        ScoreTextScript.cameraAmount += 1;
        Destroy (gameObject);
   }
}
