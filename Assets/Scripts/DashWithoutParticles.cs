using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashWithoutParticles : MonoBehaviour
{
    public float dashDistance = 5f;  // ���������� �����
    public float dashDuration = 0.3f;  // ������������ �����
    private bool isDashing = false;  // ���� ��� �������� �����
    private Vector3 dashDirection;  // ����������� �����

    private SpriteRenderer sprite; // �������� ������ �� ��������� SpriteRenderer

    private void Awake()
    {
        // �������� SpriteRenderer � ������ ����
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Update()
    {
        // ��������� ������� ������� Shift ��� ������ �����
        if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) && !isDashing)
        {
            StartCoroutine(Dash());
        }
    }

    private IEnumerator Dash()
    {
        isDashing = true;

        // ���������� ����������� ����� � ����������� �� ����������� ���������
        dashDirection = sprite.flipX ? -transform.right : transform.right;


        // ��������� �������
        Vector3 startPosition = transform.position;

        float dashTime = 0f;

        // ��������� �����
        while (dashTime < dashDuration)
        {
            // ���������� ����� � ������ �����������
            transform.position = Vector3.Lerp(startPosition, startPosition + dashDirection * dashDistance, dashTime / dashDuration);

            dashTime += Time.deltaTime;
            yield return null;
        }

        // ��������� �����
        isDashing = false;
    }
}

