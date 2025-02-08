using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public Text player1Text;
    public Text player2Text;
    public Text timerText;

    public float timer;

    public float fiveSecCounter;

    private int player1Score;
    private int player2Score;
    
    public void Player1_Scored()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        GameReset();
    }

    public void Player2_Scored()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        GameReset();
    }

    public void GameReset()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        timerText.text = timer.ToString("F2");

        fiveSecCounter += Time.deltaTime;
        if (fiveSecCounter > 5f)
        {
            ball.GetComponent<Ball>().BoostSpeed();
            fiveSecCounter = 0f;
        }
    }
}
