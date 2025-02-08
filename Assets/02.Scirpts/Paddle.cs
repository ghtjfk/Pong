using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;  // ture: Player1, false: Player2
    public float moveSpeed; // Paddle이 움직이는 속도
    public Rigidbody2D rb;  // 물리력을 이용해서 움직이게 하기 위한 변수

    private float movement; // Player1의 움직임인지 Player2의 움직임인지 설정해주는 변수

    public Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

   
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");   //Player1의 움직임
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");  //Player2의 움직임
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * moveSpeed); //물리 속성을 이용하여 움직임 제어
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
