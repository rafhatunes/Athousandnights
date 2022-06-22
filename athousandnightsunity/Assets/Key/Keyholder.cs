using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Keyholder : MonoBehaviour
{
    public event EventHandler OnKeysChanged;

   private List<Key1.KeyType> keyList;

   private void Awake()
   {
    keyList = new List<Key1.KeyType>();
   }

    public List<Key1.KeyType> GetKeyList()
    {
        return keyList;
    }
   public void AddKey(Key1.KeyType keyType)
   {
    keyList.Add(keyType);
    OnKeysChanged?.Invoke(this, EventArgs.Empty);
   }

   public void RemoveKey(Key1.KeyType keyType)
   {
    keyList.Remove(keyType);
    OnKeysChanged?.Invoke(this, EventArgs.Empty);
   }

    public bool ContainsKey(Key1.KeyType keyType)
    {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Key1 key = collider.GetComponent<Key1>();
        if (key != null)
        {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
        }

        KeyDoor keyDoor = collider.GetComponent<KeyDoor>();
        if (keyDoor != null)
        {
            if (ContainsKey(keyDoor.GetKeyType()))
            {
                RemoveKey(keyDoor.GetKeyType());
                keyDoor.OpenDoor();
            }
        }
    }

}
