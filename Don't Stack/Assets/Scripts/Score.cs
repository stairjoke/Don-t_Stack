using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    private int score = 0;

    public void updateScore(int d){
        score += d;
        scoreText.text = score.ToString();
    }
}
