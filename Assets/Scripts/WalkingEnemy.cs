using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : Entity
{
    private float speed = 0.5f;
    private Vector3 dir;
    private SpriteRenderer sprite;

    public Transform Pos;
    public float Rad;

    private void Awake(){
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        dir = transform.right;
    }

    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(Pos.position, Rad);
        //Debug.Log(colliders.Length);
        if(colliders.Length > 3)
        {
            dir *= -1f;
            //Debug.Log("dwj");
        }
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Pos.position, Rad);
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
        }
        
        if(lives <= 0)
        {
            Die();
        }
    }
}
