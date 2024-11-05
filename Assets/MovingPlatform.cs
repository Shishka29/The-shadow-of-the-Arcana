using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f; // �������� �������� ���������
    public float distance = 5f; // ���������, �� ������� ����� ��������� ���������

    private Vector2 startingPosition;
    private bool movingRight = true;

    void Start()
    {
        // ���������� ��������� ������� ���������
        startingPosition = transform.position;
    }

    void Update()
    {
        // ��������� ����������� �������� ���������
        if (movingRight)
        {
            // ������� ��������� ������
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            // ���� ��������� �������� ������� ������ �����, ������ �����������
            if (transform.position.x >= startingPosition.x + distance)
            {
                movingRight = false;
            }
        }
        else
        {
            // ������� ��������� �����
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            // ���� ��������� �������� ������� ����� �����, ������ �����������
            if (transform.position.x <= startingPosition.x - distance)
            {
                movingRight = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ���� �������� �������� ���������, ������ ��� �������� �������� ���������
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // ���� �������� �������� ���������, ������� ��� �� �������� �������� ���������
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}

