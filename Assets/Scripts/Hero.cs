using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Hero : Entity
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private int health;
    [SerializeField] float JumpForce = 11f;
    private bool isGrounded = false;
    private int hp;

    [SerializeField] private Image[] hearts;

    [SerializeField] private Sprite aliveHeart;
    [SerializeField] private Sprite deadHeart;

    private int jumpCount = 0; // ������� �������
    private int maxJumpCount = 2; // ������������ ���������� ������� (������� ������)

    public bool isAttacking = false;
    public bool isRecharged = true;

    public Transform attackPos;
    public float attackRange;
    public LayerMask enemy;

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    public static Hero Instance { get; set; }


    private Canvas DeathMenu;

    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }

    private void Awake()
    {
        DeathMenu = GameObject.Find("MenuDeath").GetComponent<Canvas>();
        DeathMenu.enabled = false;
        hp = 5;
        health = hp;
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = rb.GetComponentInChildren<SpriteRenderer>();
        Instance = this;
        isRecharged = true;
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update()
    {
        if (isGrounded && !isAttacking) State = States.idle;
        if (!isAttacking && Input.GetButton("Horizontal"))
            Run();
        if (!isAttacking && Input.GetButtonDown("Jump") && jumpCount < maxJumpCount)
            Jump();
        if (Input.GetButtonDown("Fire1"))
            Attack();

        if(health > hp){
            health = hp;
        }

        for(int i = 0; i < hearts.Length; i++){
            if(i < health){
                hearts[i].sprite = aliveHeart;
            }
            else hearts[i].sprite = deadHeart;

            //if(i < lives){
              //  hearts[i].enabled = true;
            //}
            //else hearts[i].enabled = false;
        }
        if (hp <= 0)
        {
            death();
        }
     
    }

    private void Attack()
    {
        if (isGrounded && isRecharged)
        {
            State = States.attack;
            isAttacking = true;
            isRecharged = false;

            StartCoroutine(AttackAnimation());
            StartCoroutine(AttackCoolDown());
        }
    }

    private void OnAttack()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemy);
        for (int i = 0; i < colliders.Length; i++)
        {
            colliders[i].GetComponent<Entity>().GetDamage();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

    private IEnumerator AttackAnimation()
    {
        yield return new WaitForSeconds(0.4f);
        isAttacking = false;
    }

    private IEnumerator AttackCoolDown()
    {
        yield return new WaitForSeconds(0.5f);
        isRecharged = true;
    }

    private void Run()
    {
        if (isGrounded) State = States.run;
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;
    }

    private void Jump()
    {
        if (jumpCount < maxJumpCount-1) // ������������ ���������� ������� �� maxJumpCount
        {
            rb.velocity = new Vector2(rb.velocity.x, 0); // ���������� ������������ �������� ����� �������
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            jumpCount++; // ����������� ������� �������
            State = States.jump; // ������������� ��������� ������
        }
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.8f);
        isGrounded = collider.Length > 1;

        if (isGrounded)
        {
            jumpCount = 0; // ���������� ������� ������� ��� �����������
            if (!isAttacking) State = States.idle; // ������������� ��������� idle ��� �����������
        }
        else if (jumpCount >= 1) // ��������, ���� �������� � ������
        {
            State = States.jump;
        }
        if (transform.position.y < -20)
        {
            // Если игрок находится ниже заданного числа по оси Y, установить hp равным 0
            hp = 0;
        }
    }

    public override void GetDamage()
    {
        hp -= 1;
        Debug.Log(hp);
    }

    private void death()
    {
        if (hp <= 0)
        {
            Debug.Log("death");
            if (DeathMenu.enabled == false)
            {
                Time.timeScale = 0;
                speed = 0;
                DeathMenu.enabled=true;
            }
        }
    }

}

public enum States
{
    idle,
    run,
    jump,
    attack
}