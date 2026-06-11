/// 000314083 Jordan Marshall

using UnityEngine;

public class HeartsAvailable : MonoBehaviour
{
    public float currentHearts;
    public float maxHearts;
    public Sprite noHearts;

    public GameObject gameOverMenu;

    public void NumberOfHearts(float amount)
    {
        currentHearts += amount;

        if (currentHearts <= 0) // If hearts are 0, game over menu pops up
        {
            Time.timeScale = 0;
            gameOverMenu.SetActive(true);
        }
    }
}
