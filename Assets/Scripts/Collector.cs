using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public Text scoreText;
    public int score;

    void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            IncreaseScore();
            Destroy(target.gameObject);
        }
    }
}
