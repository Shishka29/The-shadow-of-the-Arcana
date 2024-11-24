using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
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

    private Canvas сanvas;

    private void Awake()
    {
        сanvas = GameObject.Find("CharacterMenu").GetComponent<Canvas>();
        сanvas.enabled = false;
    }

        


    private void Update()
    {
        if (card0saver.card0save == true && card0 != null)
        {
            card0.GetComponent<Image>().color = Color.white;
        }
        if (card1saver.card1save == true && card1 != null)
        {
            card1.GetComponent<Image>().color = Color.white;
        }
        if (card2saver.card2save == true && card2 != null)
        {
            card2.GetComponent<Image>().color = Color.white;
        }
        if (card3saver.card3save == true && card3 != null)
        {
            card3.GetComponent<Image>().color = Color.white;
        }
        if (card4saver.card4save == true && card4 != null)
        {
            card4.GetComponent<Image>().color = Color.white;
        }
        if (card5saver.card5save == true && card5 != null)
        {
            card5.GetComponent<Image>().color = Color.white;
        }




        if (сanvas.enabled==true && Input.GetKeyDown(KeyCode.C))
        {
            сanvas.enabled = false;
        }
        else if(сanvas.enabled == false && Input.GetKeyDown(KeyCode.C))
        {
            сanvas.enabled = true;
        }

    }

   

    public void ChangeText(Button b)
    {
        if (b == button1 && card0saver.card0save == true)
        {
            buttonpressed = 1;
            addbutton.interactable = true;
            text.text = "THE FOOL" + "\n" +"Card effect"; // Меняем текст на объекте Text
        }

        else if (b == button2 && card1saver.card1save == true)
        {
            buttonpressed = 2;
            addbutton.interactable = true;
            text.text = "THE MAGITIAN" + "\n" + "Card effect"; // Меняем текст на объекте Text
        }

        else if (b == button3 && card2saver.card2save == true)
        {
            buttonpressed = 3;
            addbutton.interactable = true;
            text.text = "THE HIGH PRIESTESS" + "\n" + "Card effect"; // Меняем текст на объекте Text
        }

        else if (b == button4 && card3saver.card3save == true)
        {
            buttonpressed = 4;
            addbutton.interactable = true;
            text.text = "THE EMPRESS" + "\n" + "Card effect"; ; // Меняем текст на объекте Text
        }


        else if (b == button5 && card4saver.card4save == true)
        {
            buttonpressed = 5;
            addbutton.interactable = true;
            text.text = "THE EMPEROR" + "\n" + "Card effect"; // Меняем текст на объекте Text
        }
        else
        {
            addbutton.interactable = false;
            text.text = "CARD BLOCK!";
        }

    }



    
    




}
