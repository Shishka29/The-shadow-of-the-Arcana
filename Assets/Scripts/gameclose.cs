using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameclose : MonoBehaviour
{
    // Start is called before the first frame update
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ExitGame);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
