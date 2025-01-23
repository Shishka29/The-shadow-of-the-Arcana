using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class skill_behaviour_boss : StateMachineBehaviour
{
    public float timer;
    public float minTime;
    public float maxTime;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = Random.Range(minTime, maxTime);
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if(timer <= 0)
       {
            animator.SetTrigger("idle2");
       }
       else
       {
            timer -= Time.deltaTime;
       }
    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}