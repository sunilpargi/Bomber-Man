using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public Text scoreText;
    private int score;

   private void IncreseScore()
    {
        score++;
        scoreText.text = "Score:" + score;
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb")
        {
            IncreseScore();
            target.gameObject.SetActive(false);
        }
    }
}
