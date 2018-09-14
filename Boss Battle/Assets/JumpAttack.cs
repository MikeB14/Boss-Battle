using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAttack : StateMachineBehaviour {

    private Rigidbody2D RB;
    public int Speed;

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        RB = animator.GetComponent<Rigidbody2D>();
        animator.SetBool("DoubleJump", true);
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
        if(Input.GetButtonDown("Fire2") || Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetBool("JumpAttack", true);
            // animator.SetBool("DoubleJump", false);
            //animator.transform.Translate(0, -2, 0);
            RB.velocity = Vector2.down * Speed;
        }
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
