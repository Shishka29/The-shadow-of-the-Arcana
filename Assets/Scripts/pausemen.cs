using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemen : MonoBehaviour
{
    public static bool objectLoaded1 = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        // Проверить, загружен ли объект в сцену
        if (objectLoaded1)
        {
            // Уничтожить объект
            Destroy(gameObject);
        }
        else
        {
            // Установить флаг загрузки объекта в true
            objectLoaded1 = true;
        }
    }
}
