using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class card16saver : MonoBehaviour
{


    public static bool card16save = false;


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
            card16save = true;
            Destroy(gameObject);
        }
    }
}
