using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // �������� ��� ���������


public class CharacterMenu : MonoBehaviour
{
    public List<GameObject> card;
    private int cardid;

    // ������� ������ �� ������
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;

    public Text text; // ������ �� �����


    public void Awake()
    {
        
    }

    public void ChangeText(Button b)
    {
        if (b== button1) 
            text.text = "�����"; // ������ ����� �� ������� Text
        if (b == button2)
            text.text = "���"; // ������ ����� �� ������� Text
        if (b == button3)
            text.text = "��������� �����"; // ������ ����� �� ������� Text
        if (b == button4)
            text.text = "���������"; // ������ ����� �� ������� Text
        if (b == button5)
            text.text = "�����������"; // ������ ����� �� ������� Text
        if (b == button6)
            text.text = "����� ������� 1"; // ������ ����� �� ������� Text
        if (b == button7)
            text.text = "����� ������� 2"; // ������ ����� �� ������� Text
    }

    public void changeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }



}
