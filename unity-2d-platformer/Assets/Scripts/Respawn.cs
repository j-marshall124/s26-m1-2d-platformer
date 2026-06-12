/// 000314083 Jordan Marshall

using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Player player;
    public Vector3 respawn; // Set player respawn location in the inspector

    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.CompareTag("Player"))
        {
            player.Respawn(respawn);
        }
    }
}
