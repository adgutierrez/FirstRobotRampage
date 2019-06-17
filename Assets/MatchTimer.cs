using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchTimer : MonoBehaviour
{
    public float startTime = 300f;
    public float activeTime = 0f;

    public Text countdownText;
    public Text gameOverText;

    public Slider TimerCountdown;

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
        countdownText.text = ("" + startTime);

        if (startTime <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Match Over";
            GameOver();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Application.Quit();
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            startTime--;
        }
    }

    public void GameOver()
    {
        gameOverText.text = "Match Over!";
        gameOver = true;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
