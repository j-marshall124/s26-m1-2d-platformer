/// 000314083 Jordan Marshall

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;
    public Player playerPos;

    // Audio
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        // See if collider object is tagged as "Player"
        // (see Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(audioClip);
            collider2d.gameObject.GetComponent<HeartsAvailable>().NumberOfHearts(-1); // Loses a heart when the player dies
            //player.transform.position = playerPos.startPosition; // Resets the player postion
        }
    }
}
