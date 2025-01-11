using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnemy : Entity
{
    private void Start()
    {
        lives = 2;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject==Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
        }

        if(lives <= 0)
        {
            Die();
        }
    }
    
}
