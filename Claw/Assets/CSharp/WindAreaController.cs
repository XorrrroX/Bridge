using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindAreaController : MonoBehaviour
{
    public float fanForce = 10f; // �w�]�j���O�q
    public Vector2 windDirection = Vector2.up; // �ۭq�j����V

    private void OnTriggerStay2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // �ϥ� windDirection ����j����V
            rb.AddForce(windDirection.normalized * fanForce);
        }
    }
}
