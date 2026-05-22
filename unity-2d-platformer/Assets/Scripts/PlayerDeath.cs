using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        // See if collider object is tagged as "Player"
        // (see Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            // Get current scene
            Scene currentScene = SceneManager.GetActiveScene();
            // Reset scene
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }
}
