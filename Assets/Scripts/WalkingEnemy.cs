using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : Entity
{
    private float speed = 0.5f;
    private Vector3 dir;
    private SpriteRenderer sprite;

    private void Awake(){
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        dir = transform.right;
        lives = 5;
    }

    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * dir.x * 0.7f, 0.1f);
        //Debug.Log(colliders.Length);
        if(colliders.Length > 0)
        {
            dir *= -1f;
            Debug.Log("dwj");
        }
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Time.deltaTime);
        sprite.flipX = dir.x > 0.0f;
    }

    private void Update()
    {
        Move();
    }
    [SerializeField] private int lives = 2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
            lives--;
            Debug.Log("кошка жызн " + lives);
        }
        
        if(lives < 1)
        {
            Die();
        }
    }
}
