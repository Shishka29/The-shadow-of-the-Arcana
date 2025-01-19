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
    public Sprite spr11;
    public Sprite spr12;
    public Sprite spr13;
    public Sprite spr14;
    public Sprite spr15;
    public Sprite spr16;
    public Sprite spr17;
    public Sprite spr18;
    public Sprite spr19;
    public Sprite spr20;
    public Sprite spr21;
    public Sprite spr22;
    




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
                Hero.speed += 1;
                zansprite1 = 1;
                targetImage1.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed==2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                Hero.power += 2;
                zansprite1 = 2;
                targetImage1.sprite = spr2;
            }
            else if(CharacterMenu.buttonpressed==3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                Hero.critrate += 5;
                zansprite1 = 3;
                targetImage1.sprite = spr3;
            }
            else if(CharacterMenu.buttonpressed==4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                Hero.JumpForce += 1;
                zansprite1 = 4;
                targetImage1.sprite = spr4;
            }
            else if(CharacterMenu.buttonpressed==5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                Hero.chanceToDodge += 8;
                zansprite1 = 5;
                targetImage1.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                Hero.speed += 2;
                zansprite1 = 6;
                targetImage1.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                Hero.vost -=10;
                zansprite1 = 7;
                targetImage1.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                Hero.speed += 3;
                zansprite1 = 8;
                targetImage1.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                Hero.power += 5;
                zansprite1 = 9;
                targetImage1.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                Hero.JumpForce += 2;
                zansprite1 = 10;
                targetImage1.sprite = spr10;
            }
            else if (CharacterMenu.buttonpressed == 11 && zansprite1 != 11 && zansprite2 != 11 && zansprite3 != 11 && zansprite4 != 11 && zansprite5 != 11)
            {
                Hero.critrate += 10;
                zansprite1 = 11;
                targetImage1.sprite = spr11;
            }
            else if (CharacterMenu.buttonpressed == 12 && zansprite1 != 12 && zansprite2 != 12 && zansprite3 != 12 && zansprite4 != 12 && zansprite5 != 12)
            {
                Hero.chanceToDodge += 12;
                zansprite1 = 12;
                targetImage1.sprite = spr12;
            }
            else if (CharacterMenu.buttonpressed == 13 && zansprite1 != 13 && zansprite2 != 13 && zansprite3 != 13 && zansprite4 != 13 && zansprite5 != 13)
            {
                Hero.vost -= 15;
                zansprite1 = 13;
                targetImage1.sprite = spr13;
            }
            else if (CharacterMenu.buttonpressed == 14 && zansprite1 != 14 && zansprite2 != 14 && zansprite3 != 14 && zansprite4 != 14 && zansprite5 != 14)
            {
                Hero.power += 7;
                zansprite1 = 14;
                targetImage1.sprite = spr14;
            }
            else if (CharacterMenu.buttonpressed == 15 && zansprite1 != 15 && zansprite2 != 15 && zansprite3 != 15 && zansprite4 != 15 && zansprite5 != 15)
            {
                Hero.JumpForce += 3;
                zansprite1 = 15;
                targetImage1.sprite = spr15;
            }
            else if (CharacterMenu.buttonpressed == 16 && zansprite1 != 16 && zansprite2 != 16 && zansprite3 != 16 && zansprite4 != 16 && zansprite5 != 16)
            {
                Hero.chanceToDodge += 15;
                zansprite1 = 16;
                targetImage1.sprite = spr16;
            }
            else if (CharacterMenu.buttonpressed == 17 && zansprite1 != 17 && zansprite2 != 17 && zansprite3 != 17 && zansprite4 != 17 && zansprite5 != 17)
            {
                Hero.critrate += 15;
                zansprite1 = 17;
                targetImage1.sprite = spr17;
            }
            else if (CharacterMenu.buttonpressed == 18 && zansprite1 != 18 && zansprite2 != 18 && zansprite3 != 18 && zansprite4 != 18 && zansprite5 != 18)
            {
                Hero.speed += 4;
                zansprite1 = 18;
                targetImage1.sprite = spr18;
            }
            else if (CharacterMenu.buttonpressed == 19 && zansprite1 != 19 && zansprite2 != 19 && zansprite3 != 19 && zansprite4 != 19 && zansprite5 != 19)
            {
                Hero.chanceToDodge += 20;
                zansprite1 = 19;
                targetImage1.sprite = spr19;
            }
            else if (CharacterMenu.buttonpressed == 20 && zansprite1 != 20 && zansprite2 != 20 && zansprite3 != 20 && zansprite4 != 20 && zansprite5 != 20)
            {
                Hero.power += 10;
                zansprite1 = 20;
                targetImage1.sprite = spr20;
            }
            else if (CharacterMenu.buttonpressed == 21 && zansprite1 != 21 && zansprite2 != 21 && zansprite3 != 21 && zansprite4 != 21 && zansprite5 != 21)
            {
                Hero.critrate += 20;
                zansprite1 = 21;
                targetImage1.sprite = spr21;
            }
            else if (CharacterMenu.buttonpressed == 22 && zansprite1 != 22 && zansprite2 != 22 && zansprite3 != 22 && zansprite4 != 22 && zansprite5 != 22)
            {
                Hero.vost -= 20;
                zansprite1 = 22;
                targetImage1.sprite = spr22;
            }
        }



        else if (targetImage2.sprite == remi)
        {
            if (CharacterMenu.buttonpressed==1 && zansprite1 != 1 && zansprite2 != 1 && zansprite3 != 1 && zansprite4 != 1 && zansprite5 != 1)
            {
                Hero.speed += 1;
                zansprite2 = 1;
                targetImage2.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed==2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                Hero.power += 2;
                zansprite2 = 2;
                targetImage2.sprite = spr2;
            }
            else if (CharacterMenu.buttonpressed == 3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                Hero.critrate += 5;
                zansprite2 = 3;
                targetImage2.sprite = spr3;
            }
            else if (CharacterMenu.buttonpressed == 4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                Hero.JumpForce += 1;
                zansprite2 = 4;
                targetImage2.sprite = spr4;
            }
            else if (CharacterMenu.buttonpressed==5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                Hero.chanceToDodge += 8;
                zansprite2 = 5;
                targetImage2.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                Hero.speed += 2;
                zansprite2 = 6;
                targetImage2.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                Hero.vost -=10;
                zansprite2 = 7;
                targetImage2.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                Hero.speed += 3;
                zansprite2 = 8;
                targetImage2.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                Hero.power += 5;
                zansprite2 = 9;
                targetImage2.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                Hero.JumpForce += 2;
                zansprite2 = 10;
                targetImage2.sprite = spr10;
            }
            else if (CharacterMenu.buttonpressed == 11 && zansprite1 != 11 && zansprite2 != 11 && zansprite3 != 11 && zansprite4 != 11 && zansprite5 != 11)
            {
                Hero.critrate += 10;
                zansprite2 = 11;
                targetImage2.sprite = spr11;
            }
            else if (CharacterMenu.buttonpressed == 12 && zansprite1 != 12 && zansprite2 != 12 && zansprite3 != 12 && zansprite4 != 12 && zansprite5 != 12)
            {
                Hero.chanceToDodge += 12;
                zansprite2 = 12;
                targetImage2.sprite = spr12;
            }
            else if (CharacterMenu.buttonpressed == 13 && zansprite1 != 13 && zansprite2 != 13 && zansprite3 != 13 && zansprite4 != 13 && zansprite5 != 13)
            {
                Hero.vost -= 15;
                zansprite2 = 13;
                targetImage2.sprite = spr13;
            }
            else if (CharacterMenu.buttonpressed == 14 && zansprite1 != 14 && zansprite2 != 14 && zansprite3 != 14 && zansprite4 != 14 && zansprite5 != 14)
            {
                Hero.power += 7;
                zansprite2 = 14;
                targetImage2.sprite = spr14;
            }
            else if (CharacterMenu.buttonpressed == 15 && zansprite1 != 15 && zansprite2 != 15 && zansprite3 != 15 && zansprite4 != 15 && zansprite5 != 15)
            {
                Hero.JumpForce += 3;
                zansprite2 = 15;
                targetImage2.sprite = spr15;
            }
            else if (CharacterMenu.buttonpressed == 16 && zansprite1 != 16 && zansprite2 != 16 && zansprite3 != 16 && zansprite4 != 16 && zansprite5 != 16)
            {
                Hero.chanceToDodge += 15;
                zansprite2 = 16;
                targetImage2.sprite = spr16;
            }
            else if (CharacterMenu.buttonpressed == 17 && zansprite1 != 17 && zansprite2 != 17 && zansprite3 != 17 && zansprite4 != 17 && zansprite5 != 17)
            {
                Hero.critrate += 15;
                zansprite2 = 17;
                targetImage2.sprite = spr17;
            }
            else if (CharacterMenu.buttonpressed == 18 && zansprite1 != 18 && zansprite2 != 18 && zansprite3 != 18 && zansprite4 != 18 && zansprite5 != 18)
            {
                Hero.speed += 4;
                zansprite2 = 18;
                targetImage2.sprite = spr18;
            }
            else if (CharacterMenu.buttonpressed == 19 && zansprite1 != 19 && zansprite2 != 19 && zansprite3 != 19 && zansprite4 != 19 && zansprite5 != 19)
            {
                Hero.chanceToDodge += 20;
                zansprite2 = 19;
                targetImage2.sprite = spr19;
            }
            else if (CharacterMenu.buttonpressed == 20 && zansprite1 != 20 && zansprite2 != 20 && zansprite3 != 20 && zansprite4 != 20 && zansprite5 != 20)
            {
                Hero.power += 10;
                zansprite2 = 20;
                targetImage2.sprite = spr20;
            }
            else if (CharacterMenu.buttonpressed == 21 && zansprite1 != 21 && zansprite2 != 21 && zansprite3 != 21 && zansprite4 != 21 && zansprite5 != 21)
            {
                Hero.critrate += 20;
                zansprite2 = 21;
                targetImage2.sprite = spr21;
            }
            else if (CharacterMenu.buttonpressed == 22 && zansprite1 != 22 && zansprite2 != 22 && zansprite3 != 22 && zansprite4 != 22 && zansprite5 != 22)
            {
                Hero.vost -= 20;
                zansprite2 = 22;
                targetImage2.sprite = spr22;
            }
        }


        else if (targetImage3.sprite == remi)
        {
            if (CharacterMenu.buttonpressed == 1 && zansprite1 != 1 && zansprite2 != 1 && zansprite3 != 1 && zansprite4 != 1 && zansprite5 != 1)
            {
                Hero.speed += 1;
                zansprite3 = 1;
                targetImage3.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed == 2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                Hero.power += 2;
                zansprite3 = 2;
                targetImage3.sprite = spr2;
            }
            else if (CharacterMenu.buttonpressed == 3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                Hero.critrate += 5;
                zansprite3 = 3;
                targetImage3.sprite = spr3;
            }
            else if (CharacterMenu.buttonpressed == 4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                Hero.JumpForce += 1;
                zansprite3 = 4;
                targetImage3.sprite = spr4;
            }
            else if (CharacterMenu.buttonpressed == 5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                Hero.chanceToDodge += 8;
                zansprite3 = 5;
                targetImage3.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                Hero.speed += 2;
                zansprite3 = 6;
                targetImage3.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                Hero.vost -= 10;
                zansprite3 = 7;
                targetImage3.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                Hero.speed += 3;
                zansprite3 = 8;
                targetImage3.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                Hero.power += 5;
                zansprite3 = 9;
                targetImage3.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                Hero.JumpForce += 2;
                zansprite3 = 10;
                targetImage3.sprite = spr10;
            }
            else if (CharacterMenu.buttonpressed == 11 && zansprite1 != 11 && zansprite2 != 11 && zansprite3 != 11 && zansprite4 != 11 && zansprite5 != 11)
            {
                Hero.critrate += 10;
                zansprite3 = 11;
                targetImage3.sprite = spr11;
            }
            else if (CharacterMenu.buttonpressed == 12 && zansprite1 != 12 && zansprite2 != 12 && zansprite3 != 12 && zansprite4 != 12 && zansprite5 != 12)
            {
                Hero.chanceToDodge += 12;
                zansprite3 = 12;
                targetImage3.sprite = spr12;
            }
            else if (CharacterMenu.buttonpressed == 13 && zansprite1 != 13 && zansprite2 != 13 && zansprite3 != 13 && zansprite4 != 13 && zansprite5 != 13)
            {
                Hero.vost -= 15;
                zansprite3 = 13;
                targetImage3.sprite = spr13;
            }
            else if (CharacterMenu.buttonpressed == 14 && zansprite1 != 14 && zansprite2 != 14 && zansprite3 != 14 && zansprite4 != 14 && zansprite5 != 14)
            {
                Hero.power += 7;
                zansprite3 = 14;
                targetImage3.sprite = spr14;
            }
            else if (CharacterMenu.buttonpressed == 15 && zansprite1 != 15 && zansprite2 != 15 && zansprite3 != 15 && zansprite4 != 15 && zansprite5 != 15)
            {
                Hero.JumpForce += 3;
                zansprite3 = 15;
                targetImage3.sprite = spr15;
            }
            else if (CharacterMenu.buttonpressed == 16 && zansprite1 != 16 && zansprite2 != 16 && zansprite3 != 16 && zansprite4 != 16 && zansprite5 != 16)
            {
                Hero.chanceToDodge += 15;
                zansprite3 = 16;
                targetImage3.sprite = spr16;
            }
            else if (CharacterMenu.buttonpressed == 17 && zansprite1 != 17 && zansprite2 != 17 && zansprite3 != 17 && zansprite4 != 17 && zansprite5 != 17)
            {
                Hero.critrate += 15;
                zansprite3 = 17;
                targetImage3.sprite = spr17;
            }
            else if (CharacterMenu.buttonpressed == 18 && zansprite1 != 18 && zansprite2 != 18 && zansprite3 != 18 && zansprite4 != 18 && zansprite5 != 18)
            {
                Hero.speed += 4;
                zansprite3 = 18;
                targetImage3.sprite = spr18;
            }
            else if (CharacterMenu.buttonpressed == 19 && zansprite1 != 19 && zansprite2 != 19 && zansprite3 != 19 && zansprite4 != 19 && zansprite5 != 19)
            {
                Hero.chanceToDodge += 20;
                zansprite3 = 19;
                targetImage3.sprite = spr19;
            }
            else if (CharacterMenu.buttonpressed == 20 && zansprite1 != 20 && zansprite2 != 20 && zansprite3 != 20 && zansprite4 != 20 && zansprite5 != 20)
            {
                Hero.power += 10;
                zansprite3 = 20;
                targetImage3.sprite = spr20;
            }
            else if (CharacterMenu.buttonpressed == 21 && zansprite1 != 21 && zansprite2 != 21 && zansprite3 != 21 && zansprite4 != 21 && zansprite5 != 21)
            {
                Hero.critrate += 20;
                zansprite3 = 21;
                targetImage3.sprite = spr21;
            }
            else if (CharacterMenu.buttonpressed == 22 && zansprite1 != 22 && zansprite2 != 22 && zansprite3 != 22 && zansprite4 != 22 && zansprite5 != 22)
            {
                Hero.vost -= 20;
                zansprite3 = 22;
                targetImage3.sprite = spr22;
            }
        }


        else if (targetImage4.sprite == remi)
        {
            if (CharacterMenu.buttonpressed == 1 && zansprite1 != 1 && zansprite2 != 1 && zansprite3 != 1 && zansprite4 != 1 && zansprite5 != 1)
            {
                Hero.speed += 1;
                zansprite4 = 1;
                targetImage4.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed == 2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                Hero.power += 2;
                zansprite4 = 2;
                targetImage4.sprite = spr2;
            }
            else if (CharacterMenu.buttonpressed == 3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                Hero.critrate += 5;
                zansprite4 = 3;
                targetImage4.sprite = spr3;
            }
            else if (CharacterMenu.buttonpressed == 4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                Hero.JumpForce += 1;
                zansprite4 = 4;
                targetImage4.sprite = spr4;
            }
            else if (CharacterMenu.buttonpressed == 5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                Hero.chanceToDodge += 8;
                zansprite4 = 5;
                targetImage4.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                Hero.speed += 2;
                zansprite4 = 6;
                targetImage4.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                Hero.vost -= 10;
                zansprite5 = 7;
                targetImage5.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                Hero.speed += 3;
                zansprite4 = 8;
                targetImage4.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                Hero.power += 5;
                zansprite4 = 9;
                targetImage4.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                Hero.JumpForce += 2;
                zansprite4 = 10;
                targetImage4.sprite = spr10;
            }
            else if (CharacterMenu.buttonpressed == 11 && zansprite1 != 11 && zansprite2 != 11 && zansprite3 != 11 && zansprite4 != 11 && zansprite5 != 11)
            {
                Hero.critrate += 10;
                zansprite4 = 11;
                targetImage4.sprite = spr11;
            }
            else if (CharacterMenu.buttonpressed == 12 && zansprite1 != 12 && zansprite2 != 12 && zansprite3 != 12 && zansprite4 != 12 && zansprite5 != 12)
            {
                Hero.chanceToDodge += 12;
                zansprite4 = 12;
                targetImage4.sprite = spr12;
            }
            else if (CharacterMenu.buttonpressed == 13 && zansprite1 != 13 && zansprite2 != 13 && zansprite3 != 13 && zansprite4 != 13 && zansprite5 != 13)
            {
                Hero.vost -= 15;
                zansprite4 = 13;
                targetImage4.sprite = spr13;
            }
            else if (CharacterMenu.buttonpressed == 14 && zansprite1 != 14 && zansprite2 != 14 && zansprite3 != 14 && zansprite4 != 14 && zansprite5 != 14)
            {
                Hero.power += 7;
                zansprite4 = 14;
                targetImage4.sprite = spr14;
            }
            else if (CharacterMenu.buttonpressed == 15 && zansprite1 != 15 && zansprite2 != 15 && zansprite3 != 15 && zansprite4 != 15 && zansprite5 != 15)
            {
                Hero.JumpForce += 3;
                zansprite4 = 15;
                targetImage4.sprite = spr15;
            }
            else if (CharacterMenu.buttonpressed == 16 && zansprite1 != 16 && zansprite2 != 16 && zansprite3 != 16 && zansprite4 != 16 && zansprite5 != 16)
            {
                Hero.chanceToDodge += 15;
                zansprite4 = 16;
                targetImage4.sprite = spr16;
            }
            else if (CharacterMenu.buttonpressed == 17 && zansprite1 != 17 && zansprite2 != 17 && zansprite3 != 17 && zansprite4 != 17 && zansprite5 != 17)
            {
                Hero.critrate += 15;
                zansprite4 = 17;
                targetImage4.sprite = spr17;
            }
            else if (CharacterMenu.buttonpressed == 18 && zansprite1 != 18 && zansprite2 != 18 && zansprite3 != 18 && zansprite4 != 18 && zansprite5 != 18)
            {
                Hero.speed += 4;
                zansprite4 = 18;
                targetImage4.sprite = spr18;
            }
            else if (CharacterMenu.buttonpressed == 19 && zansprite1 != 19 && zansprite2 != 19 && zansprite3 != 19 && zansprite4 != 19 && zansprite5 != 19)
            {
                Hero.chanceToDodge += 20;
                zansprite4 = 19;
                targetImage4.sprite = spr19;
            }
            else if (CharacterMenu.buttonpressed == 20 && zansprite1 != 20 && zansprite2 != 20 && zansprite3 != 20 && zansprite4 != 20 && zansprite5 != 20)
            {
                Hero.power += 10;
                zansprite4 = 20;
                targetImage4.sprite = spr20;
            }
            else if (CharacterMenu.buttonpressed == 21 && zansprite1 != 21 && zansprite2 != 21 && zansprite3 != 21 && zansprite4 != 21 && zansprite5 != 21)
            {
                Hero.critrate += 20;
                zansprite4 = 21;
                targetImage4.sprite = spr21;
            }
            else if (CharacterMenu.buttonpressed == 22 && zansprite1 != 22 && zansprite2 != 22 && zansprite3 != 22 && zansprite4 != 22 && zansprite5 != 22)
            {
                Hero.vost -= 20;
                zansprite4 = 22;
                targetImage4.sprite = spr22;
            }
        }



        else if (targetImage5.sprite == remi)
        {
            if (CharacterMenu.buttonpressed == 1 && zansprite1 != 1 && zansprite2 != 1 && zansprite3 != 1 && zansprite4 != 1 && zansprite5 != 1)
            {
                Hero.speed += 1;
                zansprite5 = 1;
                targetImage5.sprite = spr1;
            }
            else if (CharacterMenu.buttonpressed == 2 && zansprite1 != 2 && zansprite2 != 2 && zansprite3 != 2 && zansprite4 != 2 && zansprite5 != 2)
            {
                Hero.power += 2;
                zansprite5 = 2;
                targetImage5.sprite = spr2;
            }
            else if (CharacterMenu.buttonpressed == 3 && zansprite1 != 3 && zansprite2 != 3 && zansprite3 != 3 && zansprite4 != 3 && zansprite5 != 3)
            {
                Hero.critrate += 5;
                zansprite5 = 3;
                targetImage5.sprite = spr3;
            }
            else if (CharacterMenu.buttonpressed == 4 && zansprite1 != 4 && zansprite2 != 4 && zansprite3 != 4 && zansprite4 != 4 && zansprite5 != 4)
            {
                Hero.JumpForce += 1;
                zansprite5 = 4;
                targetImage5.sprite = spr4;
            }
            else if (CharacterMenu.buttonpressed == 5 && zansprite1 != 5 && zansprite2 != 5 && zansprite3 != 5 && zansprite4 != 5 && zansprite5 != 5)
            {
                Hero.chanceToDodge += 8;
                zansprite5 = 5;
                targetImage5.sprite = spr5;
            }
            else if (CharacterMenu.buttonpressed == 6 && zansprite1 != 6 && zansprite2 != 6 && zansprite3 != 6 && zansprite4 != 6 && zansprite5 != 6)
            {
                Hero.speed += 2;
                zansprite5 = 6;
                targetImage5.sprite = spr6;
            }
            else if (CharacterMenu.buttonpressed == 7 && zansprite1 != 7 && zansprite2 != 7 && zansprite3 != 7 && zansprite4 != 7 && zansprite5 != 7)
            {
                Hero.vost -= 10;
                zansprite5 = 7;
                targetImage5.sprite = spr7;
            }
            else if (CharacterMenu.buttonpressed == 8 && zansprite1 != 8 && zansprite2 != 8 && zansprite3 != 8 && zansprite4 != 8 && zansprite5 != 8)
            {
                Hero.speed += 3;
                zansprite5 = 8;
                targetImage5.sprite = spr8;
            }
            else if (CharacterMenu.buttonpressed == 9 && zansprite1 != 9 && zansprite2 != 9 && zansprite3 != 9 && zansprite4 != 9 && zansprite5 != 9)
            {
                Hero.power += 5;
                zansprite5 = 9;
                targetImage5.sprite = spr9;
            }
            else if (CharacterMenu.buttonpressed == 10 && zansprite1 != 10 && zansprite2 != 10 && zansprite3 != 10 && zansprite4 != 10 && zansprite5 != 10)
            {
                Hero.JumpForce += 2;
                zansprite5 = 10;
                targetImage5.sprite = spr10;
            }
            else if (CharacterMenu.buttonpressed == 11 && zansprite1 != 11 && zansprite2 != 11 && zansprite3 != 11 && zansprite4 != 11 && zansprite5 != 11)
            {
                Hero.critrate += 10;
                zansprite5 = 11;
                targetImage5.sprite = spr11;
            }
            else if (CharacterMenu.buttonpressed == 12 && zansprite1 != 12 && zansprite2 != 12 && zansprite3 != 12 && zansprite4 != 12 && zansprite5 != 12)
            {
                Hero.chanceToDodge += 12;
                zansprite5 = 12;
                targetImage5.sprite = spr12;
            }
            else if (CharacterMenu.buttonpressed == 13 && zansprite1 != 13 && zansprite2 != 13 && zansprite3 != 13 && zansprite4 != 13 && zansprite5 != 13)
            {
                Hero.vost -= 15;
                zansprite5 = 13;
                targetImage5.sprite = spr13;
            }
            else if (CharacterMenu.buttonpressed == 14 && zansprite1 != 14 && zansprite2 != 14 && zansprite3 != 14 && zansprite4 != 14 && zansprite5 != 14)
            {
                Hero.power += 7;
                zansprite5 = 14;
                targetImage5.sprite = spr14;
            }
            else if (CharacterMenu.buttonpressed == 15 && zansprite1 != 15 && zansprite2 != 15 && zansprite3 != 15 && zansprite4 != 15 && zansprite5 != 15)
            {
                Hero.JumpForce += 3;
                zansprite5 = 15;
                targetImage5.sprite = spr15;
            }
            else if (CharacterMenu.buttonpressed == 16 && zansprite1 != 16 && zansprite2 != 16 && zansprite3 != 16 && zansprite4 != 16 && zansprite5 != 16)
            {
                Hero.chanceToDodge += 15;
                zansprite5 = 16;
                targetImage5.sprite = spr16;
            }
            else if (CharacterMenu.buttonpressed == 17 && zansprite1 != 17 && zansprite2 != 17 && zansprite3 != 17 && zansprite4 != 17 && zansprite5 != 17)
            {
                Hero.critrate += 15;
                zansprite5 = 17;
                targetImage5.sprite = spr17;
            }
            else if (CharacterMenu.buttonpressed == 18 && zansprite1 != 18 && zansprite2 != 18 && zansprite3 != 18 && zansprite4 != 18 && zansprite5 != 18)
            {
                Hero.speed += 4;
                zansprite5 = 18;
                targetImage5.sprite = spr18;
            }
            else if (CharacterMenu.buttonpressed == 19 && zansprite1 != 19 && zansprite2 != 19 && zansprite3 != 19 && zansprite4 != 19 && zansprite5 != 19)
            {
                Hero.chanceToDodge += 20;
                zansprite5 = 19;
                targetImage5.sprite = spr19;
            }
            else if (CharacterMenu.buttonpressed == 20 && zansprite1 != 20 && zansprite2 != 20 && zansprite3 != 20 && zansprite4 != 20 && zansprite5 != 20)
            {
                Hero.power += 10;
                zansprite5 = 20;
                targetImage5.sprite = spr20;
            }
            else if (CharacterMenu.buttonpressed == 21 && zansprite1 != 21 && zansprite2 != 21 && zansprite3 != 21 && zansprite4 != 21 && zansprite5 != 21)
            {
                Hero.critrate += 20;
                zansprite5 = 21;
                targetImage5.sprite = spr21;
            }
            else if (CharacterMenu.buttonpressed == 22 && zansprite1 != 22 && zansprite2 != 22 && zansprite3 != 22 && zansprite4 != 22 && zansprite5 != 22)
            {
                Hero.vost -= 20;
                zansprite5 = 22;
                targetImage5.sprite = spr22;
            }
        }

    }
}
