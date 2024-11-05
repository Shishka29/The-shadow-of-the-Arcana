using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform2 : MonoBehaviour
{
    public float speed = 2f; // Скорость движения платформы
    public float distance = 4f; // Дистанция, на которую будет двигаться платформа

    private Vector2 startingPosition;
    private bool movingUp = true;

    void Start()
    {
        // Запоминаем стартовую позицию платформы
        startingPosition = transform.position;
    }

    void Update()
    {
        // Проверяем направление движения платформы
        if (movingUp)
        {
            // Двигаем платформу вверх
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            // Если платформа достигла крайней верхней точки, меняем направление
            if (transform.position.y >= startingPosition.y + distance)
            {
                movingUp = false;
            }
        }
        else
        {
            // Двигаем платформу вниз
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            // Если платформа достигла крайней нижней точки, меняем направление
            if (transform.position.y <= startingPosition.y - distance)
            {
                movingUp = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Если персонаж касается платформы, делаем его дочерним объектом платформы
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Если персонаж покидает платформу, убираем его из дочерних объектов платформы
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}