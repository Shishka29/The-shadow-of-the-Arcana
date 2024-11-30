using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool end1=false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            end1 = true;
            Destroy(gameObject);
            SceneManager.LoadScene("Levels");
        }
    }
}
