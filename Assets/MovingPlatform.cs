using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f; // Скорость движения платформы
    public float distance = 5f; // Дистанция, на которую будет двигаться платформа

    private Vector2 startingPosition;
    private bool movingRight = true;

    void Start()
    {
        // Запоминаем стартовую позицию платформы
        startingPosition = transform.position;
    }

    void Update()
    {
        // Проверяем направление движения платформы
        if (movingRight)
        {
            // Двигаем платформу вправо
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            // Если платформа достигла крайней правой точки, меняем направление
            if (transform.position.x >= startingPosition.x + distance)
            {
                movingRight = false;
            }
        }
        else
        {
            // Двигаем платформу влево
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            // Если платформа достигла крайней левой точки, меняем направление
            if (transform.position.x <= startingPosition.x - distance)
            {
                movingRight = true;
            }
        }
    }
}
