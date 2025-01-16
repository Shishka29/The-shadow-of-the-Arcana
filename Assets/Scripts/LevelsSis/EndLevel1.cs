using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLevel1 : MonoBehaviour
{
    public static bool end1 = false;
    public static bool end2 = false;
    public static bool end3 = false;
    public static bool end4 = false;
    public static bool end5 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            end2 = true;
            Destroy(gameObject);
            SceneManager.LoadScene("Levels");
        }

    }
}
