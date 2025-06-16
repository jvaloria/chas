using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparrowAnimator : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //if (animator.GetBool("isClicked") )
        //{
            int currentState = animator.GetInteger("pajaritoState");
            animator.SetInteger("pajaritoState", currentState + 1);
            animator.SetBool("isClicked", false);
            animator.SetBool("isClickable", true);
            if (animator.GetInteger("pajaritoState") == 2)
            {
                animator.transform.localScale *= 0.89f;
                animator.gameObject.GetComponent<PajarilloTejado>().moveToCompensate();
            }
            if (animator.GetInteger("pajaritoState") == 3)
            {
                animator.gameObject.GetComponent<PajarilloTejado>().moveToCompensate();
                animator.transform.localScale *= 0.89f;
                animator.gameObject.GetComponent<PajarilloTejado>().EnableStory();
            }
        //}
        /*else
        {
            if(animator.GetInteger("pajaritoState") == 3)
            {
                animator.gameObject.GetComponent<PajarilloTejado>().StartFlying();
            }
        }*/
        
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
