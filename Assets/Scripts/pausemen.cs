using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemen : MonoBehaviour
{
    public static bool objectLoaded1 = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        // ���������, �������� �� ������ � �����
        if (objectLoaded1)
        {
            // ���������� ������
            Destroy(gameObject);
        }
        else
        {
            // ���������� ���� �������� ������� � true
            objectLoaded1 = true;
        }
    }
}
