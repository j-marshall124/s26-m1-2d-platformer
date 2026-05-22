using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadScene : MonoBehaviour
{
    public string sceneToLoad;
    
    public void LoadScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void RestartLevel()
    {
        // Get current scene
        Scene currentScene = SceneManager.GetActiveScene();
        // Reset scene
        SceneManager.LoadScene(currentScene.buildIndex);
    }

    public void Exit()
    {

    }
}
