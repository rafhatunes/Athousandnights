using UnityEngine;

public class Scrollbackground : MonoBehaviour
{
   public MeshRenderer mr;
   public float speed;
   void Start()
   {


   }

    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime,0);
    }
  
    
}