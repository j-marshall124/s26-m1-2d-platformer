using UnityEngine;

public class Key : MonoBehaviour
{
    // Belongs to class
    public static int NumberCollected = 0;

    // Belongs to instance
    public bool hasKey = false;

    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        // See if collider object is tagged as "Player"
        // (see Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            // Increment number of these collected
            NumberCollected += 1;

            // Disable object on it's collected
            // This must be the last thing we do
            this.gameObject.SetActive(false);
        }
    }
}
