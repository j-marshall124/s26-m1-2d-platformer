using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Player player;
    public Vector3 respawn;
    private void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.CompareTag("Player"))
        {
            player.Respawn(respawn);
        }
    }
}
