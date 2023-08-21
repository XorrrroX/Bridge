using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishAreaController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke("PlayerPassedLevel", 0.3f);
        }
    }

    private void PlayerPassedLevel()
    {
        SceneManager.LoadScene("LevelSelection");
    }
}
