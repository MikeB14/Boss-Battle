using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerAttack : MonoBehaviour {

    private Rigidbody2D RB;
    private Animator Anim;


    #region RegAttacks
    public bool IsAttacking1 = false;
    public int AttackCount = 0;
    public float Attack1Timer;
    public float Attack2Timer;
    public float Attack3Timer;
    #endregion




    IEnumerator ResetAttack1()
    {
        yield return new WaitForSeconds(Attack1Timer);
        //IsAttacking1 = false;
        //AttackCount = 0;
        Anim.SetBool("Attack1", false);
        AttackCount = 0;
       // Anim.SetBool("Idle", true);

    }

    IEnumerator ResetAttack2()
    {
        yield return new WaitForSeconds(Attack2Timer);
        Anim.SetBool("Attack2", false);
    }

    IEnumerator ResetAttack3()
    {
        yield return new WaitForSeconds(Attack3Timer);
        Anim.SetBool("Attack3", false);
        AttackCount = 0;
    }

 


	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator>();
        RB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Attack();
        ResetAttack();
        AssistAttack();
    }

    private void Attack()
    {
        if (Input.GetButtonDown("Fire1") && AttackCount == 0)
        {
            Anim.SetBool("Attack1", true);
            AttackCount = 1;
            // Anim.SetBool("Idle", false);
            // IsAttacking1 = true;

        }
        /*
        else if (Input.GetButtonDown("Fire1") && AttackCount == 1)
        {
            Anim.SetBool("Attack2", true);
            AttackCount = 2;
        }
        else if (Input.GetButtonDown("Fire1") && AttackCount == 2)
        {
            Anim.SetBool("Attack3", true);
            AttackCount = 3;
        }
        */

        
    }

    private void ResetAttack()
    {
        if (AttackCount == 1)
        {
            //Anim.SetBool("Attack1", false);

            StartCoroutine(ResetAttack1());
        }
        else if (AttackCount == 2)
        {
            StartCoroutine(ResetAttack2());
        }
        else if (AttackCount == 3)
        {
            StartCoroutine(ResetAttack3());
        }
    }

    private void AssistAttack()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Assist Attack");
            //Make assist attack later
        }
    }
}
