using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MatchTimer : MonoBehaviour
{
    float timeRemaining;
    const float timerMax = 300;

    public int timeLeft = 300;
    public Text countdownText;
    public Text gameOverText;
    public Slider timerSlider;

    public bool gameOver;

    // Use this for initialization
    void Start()
    {
        gameOver = false;
        StartCoroutine("LoseTime");
        gameOverText.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("" + timeLeft);
        timerSlider.value = CalculateSliderValue();

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Match Over";
            GameOver();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Application.Quit();
        }
    }

    private float CalculateSliderValue()
    {
        return (timeLeft / timerMax);
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }

    public void GameOver()
    {
        gameOverText.text = "Match Over!";
        gameOver = true;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
