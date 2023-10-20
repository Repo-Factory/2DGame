using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoseScreen : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void Start()
    {
        gameObject.SetActive(false);
    }

    public void DisplayGameOver(int timeElapsed)
    {
        gameObject.SetActive(true);
        text.text = "You Survived: " + timeElapsed.ToString() + " Seconds";
        PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}
