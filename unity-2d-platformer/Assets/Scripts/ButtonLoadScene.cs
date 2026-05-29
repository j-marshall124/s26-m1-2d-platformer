using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadScene : MonoBehaviour
{
    public string sceneToLoad;
    
    public void LoadScene(string sceneToLoad)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneToLoad);
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        // Get current scene
        Scene currentScene = SceneManager.GetActiveScene();
        // Reset scene
        SceneManager.LoadScene(currentScene.buildIndex);
    }

    public void Exit()
    {
        Application.Quit(); // Exits the game
    }
}
