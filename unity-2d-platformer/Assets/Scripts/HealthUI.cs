/// 000314083 Jordan Marshall

using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public float heart;
    public float maxHearts;

    public Sprite noHeart;
    public Sprite fullHeart;
    public Image[] hearts; // How many hearts are available    
    public HeartsAvailable heartsAvailable; // Talk to the HeartsAvailable script

    void Update()
    {
        heart = heartsAvailable.currentHearts;
        maxHearts = heartsAvailable.maxHearts;

        for (int i = 0; i < hearts.Length; i++) // Loop checks how many hearts are available
        {
            if (i < heart)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = noHeart;
            }
        }
    }
}
