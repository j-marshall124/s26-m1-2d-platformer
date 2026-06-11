/// 000314083 Jordan Marshall

using UnityEngine;

public class TextPopUp : MonoBehaviour
{
    public GameObject noKeyText;
    private void OnCollisionEnter2D(Collision2D collider2d)
    {
        // See if collider object is tagged as "Player"
        // (see Inspector tag on GameObject)
        if (collider2d.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            noKeyText.SetActive(true);
        }
    }
}
