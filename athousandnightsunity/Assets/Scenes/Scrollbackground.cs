using UnityEngine;

public class Scrollbackground : MonoBehaviour
{
    private Renderer myRenderer;
    private Material myMaterial;

    private float offset;

    [SerializeField] private float increase;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myMaterial = myRenderer.material;

    }
    private void Fixedupdate()
    {
        offset += increase;
        myMaterial.SetTextureOffset("_MainTex", new Vector2((offset * speed), 0));
    }

}
