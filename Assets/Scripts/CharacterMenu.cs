using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // �������� ��� ���������


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
    public GameObject card6;
    public GameObject card7;
    public GameObject card8;
    public GameObject card9;
    public GameObject card10;
    public GameObject card11;


    // ������� ������ �� ������
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;


    public static int buttonpressed = 0;



    public Button addbutton;

    public Text text; // ������ �� �����

    private Canvas Canvas;

    private void Awake()
    {
        Canvas = GameObject.Find("CharacterMenu").GetComponent<Canvas>();
        Canvas.enabled = false;
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
        if (card6saver.card6save == true && card6 != null)
        {
            card6.GetComponent<Image>().color = Color.white;
        }
        if (card7saver.card7save == true && card7 != null)
        {
            card7.GetComponent<Image>().color = Color.white;
        }
        if (card8saver.card8save == true && card8 != null)
        {
            card8.GetComponent<Image>().color = Color.white;
        }
        if (card9saver.card9save == true && card9 != null)
        {
            card9.GetComponent<Image>().color = Color.white;
        }



        if (Canvas.enabled==true && Input.GetKeyDown(KeyCode.C))
        {
            Canvas.enabled = false;
            Time.timeScale = 1;
        }
        else if(Canvas.enabled == false && Input.GetKeyDown(KeyCode.C))
        {
            Canvas.enabled = true;
            Time.timeScale = 0;
        }

    }

   

    public void ChangeText(Button b)
    {
        if (b == button1 && card0saver.card0save == true)
        {
            buttonpressed = 1;
            addbutton.interactable = true;
            text.text = "THE FOOL" + "\n" +"Card effect"; // ������ ����� �� ������� Text
        }

        else if (b == button2 && card1saver.card1save == true)
        {
            buttonpressed = 2;
            addbutton.interactable = true;
            text.text = "THE MAGITIAN" + "\n" + "Card effect"; // ������ ����� �� ������� Text
        }

        else if (b == button3 && card2saver.card2save == true)
        {
            buttonpressed = 3;
            addbutton.interactable = true;
            text.text = "THE HIGH PRIESTESS" + "\n" + "Card effect"; // ������ ����� �� ������� Text
        }

        else if (b == button4 && card3saver.card3save == true)
        {
            buttonpressed = 4;
            addbutton.interactable = true;
            text.text = "THE EMPRESS" + "\n" + "Card effect"; ; // ������ ����� �� ������� Text
        }


        else if (b == button5 && card4saver.card4save == true)
        {
            buttonpressed = 5;
            addbutton.interactable = true;
            text.text = "THE EMPEROR" + "\n" + "Card effect"; // ������ ����� �� ������� Text
        }
        

        else if (b == button6 && card5saver.card5save == true)
        {
            buttonpressed = 6;
            addbutton.interactable = true;
            text.text = "THE HEIROPHANT" + "\n" + "Card effect"; // ������ ����� �� ������� Text
        }

        else if (b == button7 && card6saver.card6save == true)
        {
            buttonpressed = 7;
            addbutton.interactable = true;
            text.text = "THE LOVERS" + "\n" + "Card effect"; // ������ ����� �� ������� Text
        }


        else if (b == button8 && card7saver.card7save == true)
        {
            buttonpressed = 8;
            addbutton.interactable = true;
            text.text = "THE CHARIOT" + "\n" + "Card effect"; // ������ ����� �� ������� Text
        }

        else if (b == button9 && card8saver.card8save == true)
        {
            buttonpressed = 9;
            addbutton.interactable = true;
            text.text = "STRENGHT" + "\n" + "Card effect"; // ������ ����� �� ������� Text
        }

        else if (b == button10 && card9saver.card9save == true)
        {
            buttonpressed = 10;
            addbutton.interactable = true;
            text.text = "THE HERMIT" + "\n" + "Card effect"; // ������ ����� �� ������� Text
        }


        else
        {
            addbutton.interactable = false;
            text.text = "CARD BLOCK!";
        }






    }



    
    




}
