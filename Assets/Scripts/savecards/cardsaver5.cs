using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class card5saver : MonoBehaviour
{


    public static bool card5save = false;


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
            card5save = true;
            Destroy(gameObject);
        }
    }
}