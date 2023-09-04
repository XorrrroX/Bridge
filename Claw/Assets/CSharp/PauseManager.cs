using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseManager : MonoBehaviour
{
    public GameObject pauseUI; // �Ȱ�UI���Ѧ�
    private bool isPaused = false;

    private void Start()
    {
        pauseUI.SetActive(false);
        //Invoke("SetPauseUI", 0.00000001f);
    }
    private void SetPauseUI()
    {
        pauseUI.SetActive(false);
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // �Ȱ��C��
            pauseUI.SetActive(true); // ��ܼȰ�UI
        }
        else
        {
            Time.timeScale = 1; // ��_�C���ɶ��y�u
            pauseUI.SetActive(false); // ���üȰ�UI
        }
    }

    public void RestartLevel()
    {
        // ���s���J��e����
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }

    public void ReturnToLevelSelection()
    {
        // �����������d����
        SceneManager.LoadScene("LevelSelection");
        Time.timeScale = 1;
    }
}
