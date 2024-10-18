using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;

     int score = 0;

     public Text winnerText; 
     
     public static ScoreScript instance;
     
     public GameObject gameOverPanel;

     private void Awake()
     {
         instance = this;
     }

    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text= score.ToString() + " points";
        
    }

    public void AddPoints()
    {
        score += 10;
        scoreText.text = score.ToString() + " points";

        if (score == 70)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
