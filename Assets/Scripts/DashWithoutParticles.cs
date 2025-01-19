using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashWithoutParticles : MonoBehaviour
{
    public float dashDistance = 5f;  // Расстояние рывка
    public float dashDuration = 0.3f;  // Длительность рывка
    private bool isDashing = false;  // Флаг для проверки рывка
    private Vector3 dashDirection;  // Направление рывка

    private SpriteRenderer sprite; // Добавили ссылку на компонент SpriteRenderer

    private void Awake()
    {
        // Получаем SpriteRenderer в начале игры
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Update()
    {
        // Проверяем нажатие клавиши Shift для начала рывка
        if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) && !isDashing)
        {
            StartCoroutine(Dash());
        }
    }

    private IEnumerator Dash()
    {
        isDashing = true;

        // Определяем направление рывка в зависимости от направления персонажа
        dashDirection = sprite.flipX ? -transform.right : transform.right;


        // Начальная позиция
        Vector3 startPosition = transform.position;

        float dashTime = 0f;

        // Выполняем рывок
        while (dashTime < dashDuration)
        {
            // Перемещаем героя в нужном направлении
            transform.position = Vector3.Lerp(startPosition, startPosition + dashDirection * dashDistance, dashTime / dashDuration);

            dashTime += Time.deltaTime;
            yield return null;
        }

        // Завершаем рывок
        isDashing = false;
    }
}

