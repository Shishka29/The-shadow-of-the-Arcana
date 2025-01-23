using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idle2_behaviour_boss : StateMachineBehaviour
{
    public float timer;
    public float minTime;
    public float maxTime;

    private Transform playerPos;
    private SpriteRenderer bossSprite;
    public float speed;
    private int rand;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        bossSprite = GameObject.FindGameObjectWithTag("boss").GetComponentInChildren<SpriteRenderer>();
        timer = Random.Range(minTime, maxTime);
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rand = Random.Range(0, 2);

        if(rand == 0)
        {
            animator.SetTrigger("attack");
        }
        if(rand == 1)
        {
            animator.SetTrigger("skill");
        }

        Vector2 target = new Vector2(playerPos.position.x, animator.transform.position.y);
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, target, speed * Time.deltaTime);
        bossSprite.flipX = target.x < 0.0f;
    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
