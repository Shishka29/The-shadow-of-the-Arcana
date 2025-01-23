using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon_enemy : Entity
{
    public float speed;
    [SerializeField] private int lives = 2;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    void Update()
    {
        Debug.Log(lives);
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
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
