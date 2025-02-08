using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;  // true: Player1Goal, false: Player2Goal

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPlayer1Goal)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().Player2_Scored();
        }
        else
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().Player1_Scored();
        }
    }
}
