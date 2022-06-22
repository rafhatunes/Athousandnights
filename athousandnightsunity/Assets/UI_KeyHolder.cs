using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_KeyHolder : MonoBehaviour
{
  [SerializeField] private Keyholder keyHolder;
  private Transform container;
  private Transform keyTemplate;

  private void Awake()
  {
    container = transform.Find("container");
    keyTemplate = container.Find("keyTemplate");
    keyTemplate.gameObject.SetActive(false);
  }

private void Start()
{
    keyHolder.OnKeysChanged += KeyHolder_OnKeysChanged;
}

private void KeyHolder_OnKeysChanged(object sender, System.EventArgs e)
{
    UpdateVisual();
}
  private void UpdateVisual()
  {
    foreach( Transform child in container){
        if (child == keyTemplate) continue;
        Destroy(child.gameObject);
    }

    List<Key1.KeyType> keyList = keyHolder.GetKeyList();
    for(int i=0; i < keyList.Count; i++)
    
    {
        Key1.KeyType keyType = keyList[i];
       Transform keyTransform = Instantiate(keyTemplate, container);
       keyTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(50 * i, 0);
        Image keyImage = keyTransform.Find("image").GetComponent<Image>();
        switch (keyType)
        {
            default:
            case Key1.KeyType.Red:keyImage.color = Color.red; break;
            case Key1.KeyType.Blue:keyImage.color = Color.blue; break;
            case Key1.KeyType.Green:keyImage.color = Color.green; break;
        }
        

    } 
  }
}