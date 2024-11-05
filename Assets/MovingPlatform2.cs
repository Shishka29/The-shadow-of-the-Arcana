using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform2 : MonoBehaviour
{
    public float speed = 2f; // �������� �������� ���������
    public float distance = 4f; // ���������, �� ������� ����� ��������� ���������

    private Vector2 startingPosition;
    private bool movingUp = true;

    void Start()
    {
        // ���������� ��������� ������� ���������
        startingPosition = transform.position;
    }

    void Update()
    {
        // ��������� ����������� �������� ���������
        if (movingUp)
        {
            // ������� ��������� �����
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            // ���� ��������� �������� ������� ������� �����, ������ �����������
            if (transform.position.y >= startingPosition.y + distance)
            {
                movingUp = false;
            }
        }
        else
        {
            // ������� ��������� ����
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            // ���� ��������� �������� ������� ������ �����, ������ �����������
            if (transform.position.y <= startingPosition.y - distance)
            {
                movingUp = true;
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