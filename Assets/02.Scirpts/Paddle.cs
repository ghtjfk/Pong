using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;  // ture: Player1, false: Player2
    public float moveSpeed; // Paddle�� �����̴� �ӵ�
    public Rigidbody2D rb;  // �������� �̿��ؼ� �����̰� �ϱ� ���� ����

    private float movement; // Player1�� ���������� Player2�� ���������� �������ִ� ����

    public Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

   
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");   //Player1�� ������
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");  //Player2�� ������
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * moveSpeed); //���� �Ӽ��� �̿��Ͽ� ������ ����
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
