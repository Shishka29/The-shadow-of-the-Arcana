using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idle_behaviour_boss : StateMachineBehaviour
{
    private int rand;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       rand = Random.Range(0, 3);

       if(rand == 0)
       {
            animator.SetTrigger("attack");
       }
       if(rand == 1)
       {
            animator.SetTrigger("skill");
       }
       if(rand == 2)
       {
            animator.SetTrigger("idle2");
       }
    }

   
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
