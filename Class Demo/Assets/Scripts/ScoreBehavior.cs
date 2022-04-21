using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehavior : MonoBehaviour
{
   private Text thisText;
    private static int score;
    
    void Start()
    {
        thisText = GetComponent<Text>();
        
        // set score value to be zero
        score = 0;
    }
    
    void Update() 
    {
        // When P is hit
        if(Input.GetKeyDown(KeyCode.P))
        {
            // add 500 points to score
            score += 1;
        }
        // update text of Text element
        thisText.text = "Score: " + score;
    }

    public static void AddScore()
    {
        // add 500 points to score
        score += 1;
    }
}



