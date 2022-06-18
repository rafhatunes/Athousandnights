using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

 

public class TriggerCutscene : MonoBehaviour {
     
    public PlayableDirector timeline;
 
    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

        void OnTriggerEnter2D(Collider2D c)

    {
        if (c.gameObject.tag == "Player")
        {
            timeline.Play();
        }

    }

}





