using UnityEngine;
using UnityEngine.SceneManagement;
 
public class LoadOnActivation : MonoBehaviour
{
    public string sceneToLoad; 
    public Vector2 playerPosition; 
    public VectorValue playerStorage; 
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Water", LoadSceneMode.Single);
         playerStorage.initialValue = playerPosition;
        SceneManager.LoadScene(sceneToLoad);
    }
}