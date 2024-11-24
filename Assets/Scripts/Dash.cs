using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashWithTransparentTrail : MonoBehaviour
{
    public TrailRenderer trailRenderer; 
    public float dashDuration = 0.2f;   // ������������ �����
    public float dashCooldown = 1f;    // �����������

    private bool canDash = true;   
    private bool isDashing = false; 
    private float dashTimeLeft;        

    public float dashForce = 20f;      // ���� �����
    private Rigidbody2D rb;      
    private Vector2 dashDirection;    // ����������� �����

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (trailRenderer != null)
            trailRenderer.emitting = false; 
    }

    private void Update()
    {
        // �������� ������� ������� ��� �����
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartDash();
        }

        if (isDashing)
        {
            dashTimeLeft -= Time.deltaTime;
            if (dashTimeLeft <= 0)
            {
                EndDash();
            }
        }
    }

    private void StartDash()
    {
        isDashing = true;
        canDash = false;
        dashTimeLeft = dashDuration;

        dashDirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0).normalized;

        if (dashDirection == Vector2.zero)
            dashDirection = Vector2.right; // �� ��������� � ����� ������

        rb.velocity = dashDirection * dashForce;

        if (trailRenderer != null)
            trailRenderer.emitting = true;
    }

    private void EndDash()
    {
        isDashing = false;

        rb.velocity = Vector2.zero;

        if (trailRenderer != null)
            trailRenderer.emitting = false;

        Invoke(nameof(ResetDash), dashCooldown);
    }

    private void ResetDash()
    {
        canDash = true; 
    }
}
