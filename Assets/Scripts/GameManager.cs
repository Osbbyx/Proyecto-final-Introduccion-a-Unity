using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text scoreText;

    int playerScore;

    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}
