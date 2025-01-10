using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenLevel : MonoBehaviour
{

    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;

    public Sprite levels1;
    public Sprite levels2;
    public Sprite levels3;
    public Sprite levels4;
    public Sprite levels5;

    public Sprite sprite;

    private void Start()
    {
        level1.onClick.AddListener(open1);
        level2.onClick.AddListener(open2);
        level3.onClick.AddListener(open3);
        level4.onClick.AddListener(open4);
        level5.onClick.AddListener(open5);
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (EndLevel.end1)
        {
            level2.interactable = true;
        }
        else if (EndLevel.end2)
        {
            level3.interactable = true;
        }
        else if (EndLevel.end3)
        {
            level4.interactable = true;
        }
        else if (EndLevel.end4)
        {
            level5.interactable = true;
        }
        back();
        //условия активации кнопок
        

    }

    public void open1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void open2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SecondScene");
    }

    public void open3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("ThirdScene");
    }

    public void open4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("FourthScene");
    }

    public void open5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LastScene");
    }

    public void back()
    {

    }
}
