using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Boss : Entity
{   
    private Vector3 dir;

    private Animator anim;
   
    private void Awake()
    {
        lives = 10;
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (lives <= 5)
        {
            anim.SetTrigger("Stage2");
        }
        //Debug.Log(lives);
        if (lives <= 0)
        {
            anim.SetTrigger("death");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
        }
    }

    public override void Die()
    {
        
    }
}
