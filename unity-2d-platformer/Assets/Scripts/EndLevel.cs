/// 000314083 Jordan Marshall

using UnityEngine;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{
    public Key key;
    public GameObject levelSelect;

    // Audio
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (key.hasKey == true)
        {
            audioSource.PlayOneShot(audioClip);
            Time.timeScale = 0; // Pauses the game when the menu is active
            levelSelect.SetActive(true);
        }
    }
}
