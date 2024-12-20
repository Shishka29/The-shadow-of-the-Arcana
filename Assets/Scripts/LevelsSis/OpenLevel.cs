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
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        back();
        //условия активации кнопок
        

    }

    public void open1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void back()
    {

    }
}
