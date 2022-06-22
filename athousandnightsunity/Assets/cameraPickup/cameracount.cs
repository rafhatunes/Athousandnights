using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cameracount : MonoBehaviour
{
    private bool hasEntered;
    void Start()
    {
        ScoreTextScript.cameraAmount = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
   {
        if(other.gameObject.CompareTag("PlayerTag") && !hasEntered)
        {
                hasEntered=true;
                 ScoreTextScript.cameraAmount += 1;
                  GetComponent<AudioSource>().Play();
        }     
        Destroy (gameObject,1);
   }


}
