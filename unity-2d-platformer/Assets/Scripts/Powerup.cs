/// 000314083 Jordan Marshall

using UnityEngine;
using UnityEngine.UI;

public class Powerup : MonoBehaviour
{
    // Belongs to instance
    public bool hasPowerup = false;

    // Audio
    public AudioSource audioSource;
    public AudioClip audioClip;

    public GameObject powerup;

    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        // See if collider object is tagged as "Player"
        // (see Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(audioClip);
            // Increment number of these collected
            //NumberCollected += 1;
            hasPowerup = true;
            // Disable object on it's collected
            // This must be the last thing we do
            powerup.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}