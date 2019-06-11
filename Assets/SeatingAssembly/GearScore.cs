using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearScore : MonoBehaviour
{
    //private GameController gameController;

    public Text scoreGearTotalText;
    public int scoreGearTotalValue;
    private int score;

    // Use this for initialization
    void Start ()
    {
        score = 0;
        UpdateScore();

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FieldCollider" || other.tag == "Player")
        {
            return;
        }

        if (other.gameObject.CompareTag("GearPickup"))
        {
            other.gameObject.SetActive(false);
            AddScore(scoreGearTotalValue);
            Debug.Log("Gear Pickup Tag" + other);

        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreGearTotalText.text = score.ToString();
        Debug.Log("Updated Fuel Score");
    }
}
