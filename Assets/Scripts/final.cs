using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    public Transform point;
    public GameObject obje;
    private bool asa = false;
    private void Update()
    {
        
     
        if (Boss.lives == 0 && asa==false)
        {

            // Создаем port
            Instantiate(obje, point.position, point.rotation);
            asa = true;
        }
    }
    
}
