using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMenu : MonoBehaviour
{
    public static bool objectLoaded = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        // ���������, �������� �� ������ � �����
        if (objectLoaded)
        {
            // ���������� ������
            Destroy(gameObject);
        }
        else
        {
            // ���������� ���� �������� ������� � true
            objectLoaded = true;
        }
    }

}
