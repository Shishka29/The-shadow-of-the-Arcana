using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class carddelite : MonoBehaviour
{
    public GameObject card0;
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    // Start is called before the first frame update
    void Start()
    {
        if (card0saver.card0save)
        {
            Destroy(card0);
        }
        if (card1saver.card1save)
        {
            Destroy(card1);
        }
        if (card2saver.card2save)
        {
            Destroy(card2);
        }
        if (card3saver.card3save)
        {
            Destroy(card3);
        }
        if (card4saver.card4save)
        {
            Destroy(card4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
