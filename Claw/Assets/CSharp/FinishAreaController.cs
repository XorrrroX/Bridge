using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishAreaController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // ���a�i�JĲ�o�ϰ��
            PlayerPassedLevel();
        }
    }

    private void PlayerPassedLevel()
    {
        // �b�o�̰��檱�a�q�L���d�������ާ@
        Debug.Log("���a�q�L�F���d�I");
    }
}
