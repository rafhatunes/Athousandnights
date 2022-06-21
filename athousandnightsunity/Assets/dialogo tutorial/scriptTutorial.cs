using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem; 

public class scriptTutorial : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] Sentences;
    private int Index = 0;
    public float DialogueSpeed;
    public Animator DialogueAnimator;
    private bool StartDialogue = true;

    private bool nextText = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current[Key.Space].wasPressedThisFrame)
        {
            if(StartDialogue)
            {
                DialogueAnimator.SetTrigger("Enter");
                StartDialogue = false;
            }
            else
            {
                if(nextText==true)
                {
                    nextText = false;
                    NextSentence();
                }
                
            }
            
        }
    }

    void NextSentence()
    {
        if(Index <= Sentences.Length -1)
        {
            DialogueText.text= "";
            StartCoroutine(WriteSentence());
        }
        else
        {
            DialogueText.text= "";
            DialogueAnimator.SetTrigger("Exit");
        }
    }
    IEnumerator WriteSentence()
    {
        foreach(char Character in Sentences[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        Index++;
        nextText=true;
    }


}