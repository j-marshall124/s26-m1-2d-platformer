/// 000314083 Jordan Marshall

using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    // Belongs to class
    public static int NumberCollected = 0;

    // Belongs to instance
    public bool hasKey = false;

    // Audio
    public AudioSource audioSource;
    public AudioClip audioClip;

    public CanvasGroup key;

    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        // See if collider object is tagged as "Player"
        // (see Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(audioClip);
            key.alpha = 1.0f;
            // Increment number of these collected
            //NumberCollected += 1;
            hasKey = true;
            // Disable object on it's collected
            // This must be the last thing we do
            this.gameObject.SetActive(false);
        }
    }
}
