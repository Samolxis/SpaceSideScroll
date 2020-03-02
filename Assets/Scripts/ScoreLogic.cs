using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    Text txt;
    public int score = 0;
    void Start()
    {
        txt = GetComponent<Text>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addToScoreVoid ()
    {
        score = score + 1;
        PrintScore();
    }

    public void PrintScore()
    {
        txt.text = "Score: " + score; 
    }
}
