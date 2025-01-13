using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddButton : MonoBehaviour
{

    public Sprite spr1;
    public Sprite spr2;
    public Sprite spr3;
    public Sprite spr4;
    public Sprite spr5;
    public Sprite spr6;
    public Sprite spr7;
    public Sprite spr8;
    public Sprite spr9;
    public Sprite spr10;
    




    public Image targetImage1;
    public Image targetImage2;
    public Image targetImage3;
    public Image targetImage4;
    public Image targetImage5;
    



    public static int zansprite1=0;
    public static int zansprite2=0;
    public static int zansprite3 = 0;
    public static int zansprite4 = 0;
    public static int zansprite5 = 0;

    public Sprite remi;


    public Button buttonadd;

    // Start is called before the first frame update
    void Start()
    {
        buttonadd.onClick.AddListener(AddCard);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddCard()
    {
        if (targetImage1.sprite == remi)
        {
            if (CharacterMenu.buttonpressed==1 && zansprite1!=1 && zansprite2 != 1 && zansprite3 != 1 && zansprite4 != 1 && zansprite5 != 1)
            {
                zansprite1 = 1;
                targetImage1.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed==2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                zansprite1 = 2;
                targetImage1.sprite = spr2;
            }
            else if(CharacterMenu.buttonpressed==3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                zansprite1 = 3;
                targetImage1.sprite = spr3;
            }
            else if(CharacterMenu.buttonpressed==4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                zansprite1 = 4;
                targetImage1.sprite = spr4;
            }
            else if(CharacterMenu.buttonpressed==5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                zansprite1 = 5;
                targetImage1.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                zansprite1 = 6;
                targetImage1.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                zansprite1 = 7;
                targetImage1.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                zansprite1 = 8;
                targetImage1.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                zansprite1 = 9;
                targetImage1.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                zansprite1 = 10;
                targetImage1.sprite = spr10;
            }
        }



        else if (targetImage2.sprite == remi)
        {
            if (CharacterMenu.buttonpressed==1 && zansprite1 != 1 && zansprite2 != 1 && zansprite3 != 1 && zansprite4 != 1 && zansprite5 != 1)
            {
                zansprite2 = 1;
                targetImage2.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed==2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                zansprite2 = 2;
                targetImage2.sprite = spr2;
            }
            else if (CharacterMenu.buttonpressed == 3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                zansprite2 = 3;
                targetImage2.sprite = spr3;
            }
            else if (CharacterMenu.buttonpressed == 4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                zansprite2 = 4;
                targetImage2.sprite = spr4;
            }
            else if (CharacterMenu.buttonpressed==5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                zansprite2 = 5;
                targetImage2.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                zansprite2 = 6;
                targetImage2.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                zansprite2 = 7;
                targetImage2.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                zansprite2 = 8;
                targetImage2.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                zansprite2 = 9;
                targetImage2.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                zansprite2 = 10;
                targetImage2.sprite = spr10;
            }
        }


        else if (targetImage3.sprite == remi)
        {
            if (CharacterMenu.buttonpressed == 1 && zansprite1 != 1 && zansprite2 != 1 && zansprite3 != 1 && zansprite4 != 1 && zansprite5 != 1)
            {
                zansprite3 = 1;
                targetImage3.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed == 2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                zansprite3 = 2;
                targetImage3.sprite = spr2;
            }
            else if (CharacterMenu.buttonpressed == 3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                zansprite3 = 3;
                targetImage3.sprite = spr3;
            }
            else if (CharacterMenu.buttonpressed == 4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                zansprite3 = 4;
                targetImage3.sprite = spr4;
            }
            else if (CharacterMenu.buttonpressed == 5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                zansprite3 = 5;
                targetImage3.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                zansprite3 = 6;
                targetImage3.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                zansprite3 = 7;
                targetImage3.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                zansprite3 = 8;
                targetImage3.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                zansprite3 = 9;
                targetImage3.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                zansprite3 = 10;
                targetImage3.sprite = spr10;
            }
        }


        else if (targetImage4.sprite == remi)
        {
            if (CharacterMenu.buttonpressed == 1 && zansprite1 != 1 && zansprite2 != 1 && zansprite3 != 1 && zansprite4 != 1 && zansprite5 != 1)
            {
                zansprite4 = 1;
                targetImage4.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed == 2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                zansprite4 = 2;
                targetImage4.sprite = spr2;
            }
            else if (CharacterMenu.buttonpressed == 3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                zansprite4 = 3;
                targetImage4.sprite = spr3;
            }
            else if (CharacterMenu.buttonpressed == 4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                zansprite4 = 4;
                targetImage4.sprite = spr4;
            }
            else if (CharacterMenu.buttonpressed == 5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                zansprite4 = 5;
                targetImage4.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                zansprite4 = 6;
                targetImage4.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                zansprite5 = 7;
                targetImage5.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                zansprite4 = 8;
                targetImage4.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                zansprite4 = 9;
                targetImage4.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                zansprite4 = 10;
                targetImage4.sprite = spr10;
            }
        }



        else if (targetImage5.sprite == remi)
        {
            if (CharacterMenu.buttonpressed == 1 && zansprite1 != 1 && zansprite2 != 1 && zansprite3 != 1 && zansprite4 != 1 && zansprite5 != 1)
            {
                zansprite5 = 1;
                targetImage5.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed == 2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                zansprite5 = 2;
                targetImage5.sprite = spr2;
            }
            else if (CharacterMenu.buttonpressed == 3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                zansprite5 = 3;
                targetImage5.sprite = spr3;
            }
            else if (CharacterMenu.buttonpressed == 4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                zansprite5 = 4;
                targetImage5.sprite = spr4;
            }
            else if (CharacterMenu.buttonpressed == 5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                zansprite5 = 5;
                targetImage5.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                zansprite5 = 6;
                targetImage5.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                zansprite5 = 7;
                targetImage5.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                zansprite5 = 8;
                targetImage5.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                zansprite5 = 9;
                targetImage5.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                zansprite5 = 10;
                targetImage5.sprite = spr10;
            }
        }

    }
}
