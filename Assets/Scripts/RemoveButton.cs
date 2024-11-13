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
            targetImageq1.sprite = remiq;
            AddButton.zansprite1 = 0;
        }
        else if (AddButton.zansprite2 == CharacterMenu.buttonpressed)
        {
            targetImageq2.sprite = remiq;
            AddButton.zansprite2 = 0;
        }
        else if (AddButton.zansprite3 == CharacterMenu.buttonpressed)
        {
            targetImageq3.sprite = remiq;
            AddButton.zansprite3 = 0;
        }
        else if (AddButton.zansprite4 == CharacterMenu.buttonpressed)
        {
            targetImageq4.sprite = remiq;
            AddButton.zansprite4 = 0;
        }
        else if (AddButton.zansprite5 == CharacterMenu.buttonpressed)
        {
            targetImageq5.sprite = remiq;
            AddButton.zansprite5 = 0;
        }
    }


}
