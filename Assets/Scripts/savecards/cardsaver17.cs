using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class card17saver : MonoBehaviour
{


    public static bool card17save = false;


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
            card17save = true;
            Destroy(gameObject);
        }
    }
}
