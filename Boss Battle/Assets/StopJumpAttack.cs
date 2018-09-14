﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopJumpAttack : StateMachineBehaviour {


    public int WaitTime = 0;
    public int WaitTimeLimit;
    private Rigidbody2D RB;
    public float Speed;
	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        RB = animator.GetComponent<Rigidbody2D>();
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        WaitTime++;

        if(WaitTime >= WaitTimeLimit)
        {
            animator.SetBool("JumpAttack", false);
            WaitTime = 0;
        }

        RB.velocity = Vector2.down * Speed;
    }

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        RB.velocity = Vector2.zero;
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
