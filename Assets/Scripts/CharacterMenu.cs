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


    public GameObject card0;
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;



    // Добавим ссылки на кнопки
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;


    public static int buttonpressed = 0;



    public Button addbutton;

    public Text text; // Ссылка на текст


    public void Start()
    {
        if (card0saver.card0save == true && card0 != null)
        {
            card0.GetComponent<Image>().color = Color.green;
        }
        if (card1saver.card1save == true && card0 != null)
        {
            card1.GetComponent<Image>().color = Color.green;
        }
        if (card2saver.card2save == true && card0 != null)
        {
            card2.GetComponent<Image>().color = Color.green;
        }
        if (card3saver.card3save == true && card0 != null)
        {
            card3.GetComponent<Image>().color = Color.green;
        }
        if (card4saver.card4save == true && card0 != null)
        {
            card4.GetComponent<Image>().color = Color.green;
        }
    }


    public void ChangeText(Button b)
    {
        if (b == button1 && card0saver.card0save == true)
        {
            buttonpressed = 1;
            addbutton.interactable = true;
            text.text = "Дурак"; // Меняем текст на объекте Text
        }

        else if (b == button2 && card1saver.card1save == true)
        {
            buttonpressed = 2;
            addbutton.interactable = true;
            text.text = "Маг"; // Меняем текст на объекте Text
        }

        else if (b == button3 && card2saver.card2save == true)
        {
            buttonpressed = 3;
            addbutton.interactable = true;
            text.text = "Жрица"; // Меняем текст на объекте Text
        }

        else if (b == button4 && card3saver.card3save == true)
        {
            buttonpressed = 4;
            addbutton.interactable = true;
            text.text = "Император"; // Меняем текст на объекте Text
        }


        else if (b == button5 && card4saver.card4save == true)
        {
            buttonpressed = 5;
            addbutton.interactable = true;
            text.text = "Императрица"; // Меняем текст на объекте Text
        }
        else
        {
            addbutton.interactable = false;
            text.text = "Карта заблокирована!";
        }

    }



    
    

    public void changeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }



}
