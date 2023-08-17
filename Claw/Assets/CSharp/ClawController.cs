using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool hasCollided = false; // �����O�_�I���L
    private float maxDistance;
    public GameObject CaughtObject;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        maxDistance = FindObjectOfType<PlayerController>().maxSwingDistance;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        CaughtObject = collision.gameObject;
        if (collision.gameObject.CompareTag("Floor") && !hasCollided)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            hasCollided = true;
        }
        if (collision.gameObject.CompareTag("Fan") && !hasCollided)
        {
            Destroy(gameObject);
        }
    }
    public bool isCaught()
    {
        return hasCollided;
    }

    private void Update()
    {
        if (!hasCollided)
        {
            // �b�I���e�A�i�H�b�o�̳B�z���l�������޿�
        }
        Vector2 playerPosition = transform.parent.position; // ���]���a�O���l��������
        Vector2 clawPosition = transform.position;
        float distance = Vector2.Distance(playerPosition, clawPosition);

        if (distance > maxDistance)
        {
            Destroy(gameObject); // �W�X�̤j���סA�P�����l����
        }
    }
}
