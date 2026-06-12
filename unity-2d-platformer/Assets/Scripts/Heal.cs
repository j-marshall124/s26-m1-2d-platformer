/// 000314083 Jordan Marshall

using UnityEngine;

public class Heal : MonoBehaviour
{
    public HeartsAvailable hearts;

    // Audio
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        // See if collider object is tagged as "Player"
        // (see Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            if (hearts.currentHearts == 3)
            {
                return; // If player is full hearts
            }
            else
            {
                audioSource.PlayOneShot(audioClip);
                hearts.currentHearts += 1; // Heals the player by 1 heart
                // Disable object on it's collected
                // This must be the last thing we do
                this.gameObject.SetActive(false);
            }
            
        }
    }
}
