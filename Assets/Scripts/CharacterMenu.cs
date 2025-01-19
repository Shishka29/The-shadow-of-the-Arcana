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
    public GameObject card12;
    public GameObject card13;
    public GameObject card14;
    public GameObject card15;
    public GameObject card16;
    public GameObject card17;
    public GameObject card18;
    public GameObject card19;
    public GameObject card20;
    public GameObject card21;


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
    public Button button12;
    public Button button13;
    public Button button14;
    public Button button15;
    public Button button16;
    public Button button17;
    public Button button18;
    public Button button19;
    public Button button20;
    public Button button21;
    public Button button22;


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
        if (card10saver.card10save == true && card10 != null)
        {
            card10.GetComponent<Image>().color = Color.white;
        }
        if (card11saver.card11save == true && card11 != null)
        {
            card11.GetComponent<Image>().color = Color.white;
        }
        if (card12saver.card12save == true && card12 != null)
        {
            card12.GetComponent<Image>().color = Color.white;
        }
        if (card13saver.card13save == true && card13 != null)
        {
            card13.GetComponent<Image>().color = Color.white;
        }
        if (card14saver.card14save == true && card14 != null)
        {
            card14.GetComponent<Image>().color = Color.white;
        }
        if (card15saver.card15save == true && card15 != null)
        {
            card15.GetComponent<Image>().color = Color.white;
        }
        if (card16saver.card16save == true && card16 != null)
        {
            card16.GetComponent<Image>().color = Color.white;
        }
        if (card17saver.card17save == true && card17 != null)
        {
            card17.GetComponent<Image>().color = Color.white;
        }
        if (card18saver.card18save == true && card18 != null)
        {
            card18.GetComponent<Image>().color = Color.white;
        }
        if (card19saver.card19save == true && card19 != null)
        {
            card19.GetComponent<Image>().color = Color.white;
        }
        if (card20saver.card20save == true && card20 != null)
        {
            card20.GetComponent<Image>().color = Color.white;
        }
        if (card21saver.card21save == true && card21 != null)
        {
            card21.GetComponent<Image>().color = Color.white;
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
            text.text = "THE FOOL" + "\n" +"+1 speed"; // ������ ����� �� ������� Text
        }

        else if (b == button2 && card1saver.card1save == true)
        {
            buttonpressed = 2;
            addbutton.interactable = true;
            text.text = "THE MAGITIAN" + "\n" + "+2 strength"; // ������ ����� �� ������� Text
        }

        else if (b == button3 && card2saver.card2save == true)
        {
            buttonpressed = 3;
            addbutton.interactable = true;
            text.text = "THE PRIESTESS" + "\n" + "+5 crit rate"; // ������ ����� �� ������� Text
        }

        else if (b == button4 && card3saver.card3save == true)
        {
            buttonpressed = 4;
            addbutton.interactable = true;
            text.text = "THE EMPRESS" + "\n" + "+1 jump power"; ; // ������ ����� �� ������� Text
        }


        else if (b == button5 && card4saver.card4save == true)
        {
            buttonpressed = 5;
            addbutton.interactable = true;
            text.text = "THE EMPEROR" + "\n" + "+8 dodge chance"; // ������ ����� �� ������� Text
        }
        

        else if (b == button6 && card5saver.card5save == true)
        {
            buttonpressed = 6;
            addbutton.interactable = true;
            text.text = "THE HEIROPHANT" + "\n" + "+2 speed"; // ������ ����� �� ������� Text
        }

        else if (b == button7 && card6saver.card6save == true)
        {
            buttonpressed = 7;
            addbutton.interactable = true;
            text.text = "THE LOVERS" + "\n" + "-10 heal time"; // ������ ����� �� ������� Text
        }


        else if (b == button8 && card7saver.card7save == true)
        {
            buttonpressed = 8;
            addbutton.interactable = true;
            text.text = "THE CHARIOT" + "\n" + "+3 speed"; // ������ ����� �� ������� Text
        }

        else if (b == button9 && card8saver.card8save == true)
        {
            buttonpressed = 9;
            addbutton.interactable = true;
            text.text = "STRENGHT" + "\n" + "+5 power"; // ������ ����� �� ������� Text
        }

        else if (b == button10 && card9saver.card9save == true)
        {
            buttonpressed = 10;
            addbutton.interactable = true;
            text.text = "THE HERMIT" + "\n" + "+2 jump power"; // ������ ����� �� ������� Text
        }

        else if (b == button11 && card10saver.card10save == true)
        {
            buttonpressed = 11;
            addbutton.interactable = true;
            text.text = "WHEEL OF FORTUNE" + "\n" + "+10 crit rate"; // ������ ����� �� ������� Text
        }

        else if (b == button12 && card11saver.card11save == true)
        {
            buttonpressed = 12;
            addbutton.interactable = true;
            text.text = "JUSTICE" + "\n" + "+10 dodge chance"; // ������ ����� �� ������� Text
        }

        else if (b == button13 && card12saver.card12save == true)
        {
            buttonpressed = 13;
            addbutton.interactable = true;
            text.text = "THE HANGED" + "\n" + "-15 heal time"; // ������ ����� �� ������� Text
        }

        else if (b == button14 && card13saver.card13save == true)
        {
            buttonpressed = 14;
            addbutton.interactable = true;
            text.text = "DEATH" + "\n" + "+7 power"; // ������ ����� �� ������� Text
        }

        else if (b == button15 && card14saver.card14save == true)
        {
            buttonpressed = 15;
            addbutton.interactable = true;
            text.text = "TEMPERANCE" + "\n" + "+3 jump power"; // ������ ����� �� ������� Text
        }

        else if (b == button16 && card15saver.card15save == true)
        {
            buttonpressed = 16;
            addbutton.interactable = true;
            text.text = "THE DEVIL" + "\n" + "+15 dodge chance"; // ������ ����� �� ������� Text
        }

        else if (b == button17 && card16saver.card16save == true)
        {
            buttonpressed = 17;
            addbutton.interactable = true;
            text.text = "THE TOWER" + "\n" + "+15 crit rate"; // ������ ����� �� ������� Text
        }

        else if (b == button18 && card17saver.card17save == true)
        {
            buttonpressed = 18;
            addbutton.interactable = true;
            text.text = "THE STAR" + "\n" + "+4 speed"; // ������ ����� �� ������� Text
        }

        else if (b == button19 && card18saver.card18save == true)
        {
            buttonpressed = 19;
            addbutton.interactable = true;
            text.text = "THE MOON" + "\n" + "+20 dodge chance"; // ������ ����� �� ������� Text
        }

        else if (b == button20 && card19saver.card19save == true)
        {
            buttonpressed = 20;
            addbutton.interactable = true;
            text.text = "THE SUN" + "\n" + "+10 power"; // ������ ����� �� ������� Text
        }

        else if (b == button21 && card20saver.card20save == true)
        {
            buttonpressed = 21;
            addbutton.interactable = true;
            text.text = "JUDGEMENT" + "\n" + "+20 crit rate"; // ������ ����� �� ������� Text
        }

        else if (b == button22 && card21saver.card21save == true)
        {
            buttonpressed = 22;
            addbutton.interactable = true;
            text.text = "THE WORLD" + "\n" + "-20 heal time"; // ������ ����� �� ������� Text
        }

        else
        {
            addbutton.interactable = false;
            text.text = "CARD BLOCK!";
        }






    }



    
    




}
