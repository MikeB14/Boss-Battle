using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1 : StateMachineBehaviour {

    public int AttackCount = 0;
   // public int ResetTime;
   // public int ResetTimeLimit;


	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

   

    }

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

     

        if (Input.GetButtonDown("Fire1") && AttackCount == 0)
        {
            animator.SetBool("Attack1", true);
            //ResetTime++;
            AttackCount = 1;
        }
        
        else if (Input.GetButtonDown("Fire1") && AttackCount == 1)
        {
            animator.SetBool("Attack2", true);
            AttackCount = 2;
        }
        else if(Input.GetButtonDown("Fire1") && AttackCount == 2)
        {
            animator.SetBool("Attack3", true);
            AttackCount = 0;
        }


  


        /*
        if(ResetTime >= ResetTimeLimit)
        {
            animator.SetBool("Attack1", false);
            ResetTime = 0;
        }
        */
    }

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}


	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
