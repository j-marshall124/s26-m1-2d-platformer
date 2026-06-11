/// 000314083 Jordan Marshall

using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject endLevel;

    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        // See if collider object is tagged as "Player"
        // (see Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            endLevel.SetActive(true);
        }
    }
}
