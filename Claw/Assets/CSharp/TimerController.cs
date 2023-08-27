using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText; // TextMeshPro ���󪺰Ѧ�

    private float timer = 0f; // �p�ɾ��ܼơA��l�Ƭ� 0

    private void Start()
    {
        // ���m�p�ɾ��ö}�l�p��
        timer = 0f;
    }

    private void Update()
    {
        // ��s�p�ɾ�
        timer += Time.deltaTime;

        // �N�p�ɾ�������ܦb TextMeshPro ��r�ؤW
        DisplayTimer();
    }

    private void DisplayTimer()
    {
        // �ϥ� string.Format �榡�Ƥ�r���e�A�u����p���I����
        timerText.text = string.Format("Time: {0:F2}", timer);
    }
}

