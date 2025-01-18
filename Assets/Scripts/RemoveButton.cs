using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveButton : MonoBehaviour
{

    public Button add;
    public Button remove;


    public Image targetImageq1;
    public Image targetImageq2;
    public Image targetImageq3;
    public Image targetImageq4;
    public Image targetImageq5;

    public Sprite remiq;

    private int a;
    // Start is called before the first frame update
    void Start()
    {
        remove.onClick.AddListener(removework);
    }

    // Update is called once per frame
    void Update()
    {
        if (add.interactable && (AddButton.zansprite1==CharacterMenu.buttonpressed|| AddButton.zansprite2 == CharacterMenu.buttonpressed || AddButton.zansprite3 == CharacterMenu.buttonpressed || AddButton.zansprite4 == CharacterMenu.buttonpressed || AddButton.zansprite5 == CharacterMenu.buttonpressed ))
        {
            remove.interactable = true;
        }
        else 
        {
            remove.interactable=false;
        }

    }

    private void removework()
    {
        if (AddButton.zansprite1 == CharacterMenu.buttonpressed)
        {
            a= AddButton.zansprite1;
            targetImageq1.sprite = remiq;
            AddButton.zansprite1 = 0;
        }
        else if (AddButton.zansprite2 == CharacterMenu.buttonpressed)
        {
            a = AddButton.zansprite2;
            targetImageq2.sprite = remiq;
            AddButton.zansprite2 = 0;
        }
        else if (AddButton.zansprite3 == CharacterMenu.buttonpressed)
        {a = AddButton.zansprite3;
            targetImageq3.sprite = remiq;
            AddButton.zansprite3 = 0;
        }
        else if (AddButton.zansprite4 == CharacterMenu.buttonpressed)
        {a = AddButton.zansprite4;
            targetImageq4.sprite = remiq;
            AddButton.zansprite4 = 0;
        }
        else if (AddButton.zansprite5 == CharacterMenu.buttonpressed)
        {a = AddButton.zansprite5;
            targetImageq5.sprite = remiq;
            AddButton.zansprite5 = 0;
        }
        //скорость
        if (a == 1)
        {
            Hero.speed -= 1;
        }
        else if (a == 6)
        {
            Hero.speed -=2 ;
        }
        else if (a == 8)
        {
            Hero.speed -= 3;
        }
        else if (a == 18)
        {
            Hero.speed -= 4;
        }
        //прыжок
        else if (a == 4)
        {
            Hero.JumpForce -= 1;
        }
        else if (a == 10)
        {
            Hero.JumpForce -= 2;
        }
        else if (a == 15)
        {
            Hero.JumpForce -= 3;
        }
        //уклон
        else if (a == 5)
        {
            Hero.chanceToDodge -= 8;
        }
        else if (a == 12)
        {
            Hero.chanceToDodge -= 12;
        }
        else if (a == 16)
        {
            Hero.chanceToDodge -= 15;
        }
        else if (a == 19)
        {
            Hero.chanceToDodge -= 20;
        }
    }


}
