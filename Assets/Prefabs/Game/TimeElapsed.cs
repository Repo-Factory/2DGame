using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeElapsed : MonoBehaviour
{
    public TextMeshProUGUI timeText; // Reference to a UI Text component
    public GameOver gameOverScreen;
    public const int LEVEL_TIME = 180;

    private float elapsedTime;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        string formattedTime = FormatTime(elapsedTime);
        timeText.text = "Time Elapsed: " + formattedTime;
        checkGameOver();
    }

    string FormatTime(float seconds)
    {
        int minutes = Mathf.FloorToInt(seconds / 60);
        int remainingSeconds = Mathf.FloorToInt(seconds % 60);
        string formattedTime = string.Format("{0:00}:{1:00}", minutes, remainingSeconds);
        return formattedTime;
    }

    void checkGameOver()
    {
        if (elapsedTime >= LEVEL_TIME)
        {
            gameOverScreen.DisplayGameOver((int)elapsedTime);
        }
    }
}