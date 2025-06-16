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
        int currentState = animator.GetInteger("pajaritoState");
        animator.SetInteger("pajaritoState", currentState + 1);
        animator.SetBool("isClicked", false);
        animator.SetBool("isClickable", true);
        if(animator.GetInteger("pajaritoState") == 2)
        {
            //animator.transform.position = new Vector3(-190.7f, 46.2f, 0f);
            Debug.Log("no me anda la linea de arriba, lo manda a cualquier lado. ver trigerear cambio de posicion en otro lado");
            animator.transform.localScale *= 0.89f;
        }
        if (animator.GetInteger("pajaritoState") == 3)
        {
            animator.transform.localScale *= 0.89f;
            //animator.gameObject.transform.position = new Vector3(-130, 46.4f, 0f);
            Debug.Log("no me anda la linea de arriba, lo manda a cualquier lado. ver trigerear cambio de posicion en otro lado");
            animator.gameObject.GetComponent<PajarilloTejado>().EnableStory();
        }
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
