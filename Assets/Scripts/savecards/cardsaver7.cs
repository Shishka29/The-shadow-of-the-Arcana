using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class card7saver : MonoBehaviour
{


    public static bool card7save = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            card7save = true;
            Destroy(gameObject);
        }
    }
}
