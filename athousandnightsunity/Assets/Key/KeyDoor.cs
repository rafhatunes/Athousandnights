using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
   [SerializeField] private Key1.KeyType keyType;

   public Key1.KeyType GetKeyType()
   {
    return keyType;
   }
    
    public void OpenDoor()
    {
        gameObject.SetActive(false);
    }
}
