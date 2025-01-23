#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScrin : MonoBehaviour
{
    public Button buttonRest;
    void Start()
    {
        buttonRest.onClick.AddListener(ReStart);
    }
    public void ReStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
#endif