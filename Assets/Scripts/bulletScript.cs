using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        UnityEngine.Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new UnityEngine.Vector2(moveDir.x, moveDir.y);
        //Destroy(this.gameObject, 2);
    }

    
    void Update()
    {
        
    }
}
