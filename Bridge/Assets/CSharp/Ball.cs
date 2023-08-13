using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed = 5f; // ���ʳt��
    public float maxSpeed = 10f; // �̤j�t��

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // ���������J

        // �ھګ����J�I�[�O�q
        if (horizontalInput != 0)
        {
            Vector2 moveDirection = new Vector2(horizontalInput, 0);
            rb.AddForce(moveDirection * moveSpeed);

            // ����̤j�t��
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed), rb.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) // �ھڱ׭���Tag�i��P�w
        {
            Vector2 normal = collision.contacts[0].normal;
            Vector2 reflectedDirection = Vector2.Reflect(transform.right, normal); // �Ϯg��V
            GetComponent<Rigidbody2D>().velocity = reflectedDirection.normalized * GetComponent<Rigidbody2D>().velocity.magnitude;
        }
    }
}
