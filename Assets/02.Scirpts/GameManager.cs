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
    private bool isGameOver = false;

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

    private void GameOver()
    {
        isGameOver = true;

        // 공 멈추기
        ball.SetActive(false);

        // 게임 결과 출력
        if (player1Score > player2Score)
        {
            timerText.text = "Player 1 Wins!";
        }
        else if (player2Score > player1Score)
        {
            timerText.text = "Player 2 Wins!";
        }
        else
        {
            timerText.text = "Draw!";
        }
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("F2");

        fiveSecCounter += Time.deltaTime;
        if (fiveSecCounter > 20f)
        {
            ball.GetComponent<Ball>().BoostSpeed();
            fiveSecCounter = 0f;
        }

        if(timer <= 0)
        {
            GameOver();
        }
    }
}
