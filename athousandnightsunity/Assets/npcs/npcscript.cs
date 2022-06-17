using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.InputSystem;
public class npcscript : MonoBehaviour
{
    public GameObject dialogPanel;
    public Text dialogText;
    public string [] dialog;
    public int indexi;

    public GameObject contButton;
    public float wordSpeedi;
    public bool playerIsClosi;
    


    public void Update()
    {  
         if(Keyboard.current[Key.F].wasPressedThisFrame && playerIsClosi)
        {
            if(dialogPanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialogPanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if(dialogText.text == dialog[indexi])
        {
            contButton.SetActive(true);
        }
        
    }

    public void zeroText()
    {
        dialogText.text = "";
        indexi = 0;
        dialogPanel.SetActive(false);

    }

    IEnumerator Typing()
    {
        foreach(char letter in dialog[indexi].ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(wordSpeedi);
        }
    }

    public void NextLine()
    {   
        contButton.SetActive(false);

        if(indexi < dialog.Length - 1)
        {
            indexi++;
            dialogText.text = "";
            StartCoroutine(Typing());
        }
        else 
        {
            zeroText();
        }
    }
    private void OntriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            playerIsClosi = true;
        }
    }

     private void OntriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            playerIsClosi = false;
            zeroText();
        }
    }
}

