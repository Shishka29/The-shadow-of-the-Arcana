using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DataSaver : MonoBehaviour
{
    public string objectName;
    public int id;

    public void SaveInt()
    {
        PlayerPrefs.SetInt(objectName, id);
    }

}
