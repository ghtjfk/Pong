using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    public Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        Init();
    }

    private void Init()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(moveSpeed * x, moveSpeed * y);

    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Init();
    }

    public void BoostSpeed()
    {
        moveSpeed += 1;
        rb.velocity = new Vector2(rb.velocity.x + moveSpeed, rb.velocity.y + moveSpeed);
    }
}
