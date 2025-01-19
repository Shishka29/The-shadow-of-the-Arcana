using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public static int lives;
    public static int power = 2;
    public virtual void GetDamage()
    {
        lives = lives - power;
        if (lives <= 0)
            Die();
    }
    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
}
