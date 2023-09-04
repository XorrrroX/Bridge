using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathAreaController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // ���a�I�즺�`�ϰ��
            PlayerFailed();
        }
    }

    private void PlayerFailed()
    {
        // �b�o�̰��檱�a���Ѫ������ާ@
        Debug.Log("���a���ѡI���s�}�l���d");

        // ���s���J��e����
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
