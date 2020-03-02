using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    Text txt;
    public int score = 0;
    public int ePoint =1;
    void Start()
    {
        txt = GetComponent<Text>();    
    }

    public void AddToScoreVoid ()
    {
        score += ePoint;
        PrintScore();
    }

    public void PrintScore()
    {
        txt.text = "Score: " + score; 
    }
}
