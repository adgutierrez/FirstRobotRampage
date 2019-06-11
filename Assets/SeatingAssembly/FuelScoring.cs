using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScoring : MonoBehaviour
{
    public GameObject effectObject;
    public Text scoreTotalText;
    public int scoreTotalValue;
    private int score;

    // Use this for initialization
    void Start ()
    {
        effectObject.SetActive(false);
        score = 0;
        UpdateScore();
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if(otherCollider.GetComponent<Collider>() != null)
        {
            effectObject.SetActive(true);
            AddScore(scoreTotalValue);
            
            Debug.Log("matched collider requiredments");
        }
    }

    void Update () {
		
	}

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreTotalText.text = score.ToString();
        Debug.Log("Updated Fuel Score");
    }
}
