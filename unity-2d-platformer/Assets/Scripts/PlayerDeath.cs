using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        // See if collider object is tagged as "Player"
        // (see Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            collider2d.gameObject.GetComponent<HeartsAvailable>().NumberOfHearts(-1);
            player.transform.position = new Vector2(0,1);
        }
    }
}
