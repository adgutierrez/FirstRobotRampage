using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] int scorePerFuelUnit = 1;

    int score;
    Text scoreText;

	// Use this for initialization
	void Start ()
    {
        scoreText = GetComponent<Text>();
        //scoreText.Text = score.ToString;
	}
	
	public void ScoreHit()
    {
        score = score + scorePerFuelUnit;
        scoreText.text = score.ToString();
    }
}
