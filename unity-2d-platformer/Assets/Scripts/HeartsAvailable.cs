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

        if (currentHearts <= 0)
        {
            Time.timeScale = 0;
            gameOverMenu.SetActive(true);
        }
    }
}
