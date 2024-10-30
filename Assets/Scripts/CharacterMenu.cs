using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Добавьте эту директиву


public class CharacterMenu : MonoBehaviour
{
    public List<GameObject> card;
    private int cardid;

    // Добавим ссылки на кнопки
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;

    public Text text; // Ссылка на текст


    public void Awake()
    {
        
    }

    public void ChangeText(Button b)
    {
        if (b== button1) 
            text.text = "Дурак"; // Меняем текст на объекте Text
        if (b == button2)
            text.text = "Маг"; // Меняем текст на объекте Text
        if (b == button3)
            text.text = "Верховная жрица"; // Меняем текст на объекте Text
        if (b == button4)
            text.text = "Император"; // Меняем текст на объекте Text
        if (b == button5)
            text.text = "Императрица"; // Меняем текст на объекте Text
        if (b == button6)
            text.text = "Текст изменен 1"; // Меняем текст на объекте Text
        if (b == button7)
            text.text = "Текст изменен 2"; // Меняем текст на объекте Text
    }

    public void changeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }



}
