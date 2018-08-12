using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerAttack : MonoBehaviour {


    #region RegAttacks
    
    private Animator Anim;
    public bool IsAttacking1 = false;
    private int AttackCount = 0;
    public float Attack1Timer;
    #endregion

    #region SpecAttacks
    private Rigidbody2D RB;
    public float UltAttackTimer;
    private int UltAttackCount = 0;
    public int UltAttackMeter = 0;
   // public float UltAttackSpeed;
    #endregion


    IEnumerator ResetAttack1()
    {
        yield return new WaitForSeconds(Attack1Timer);
        //IsAttacking1 = false;
        AttackCount = 0;
        Anim.SetBool("Attack1", false);
       // Anim.SetBool("Idle", true);

    }

    IEnumerator ResetUltAttack()
    {
       yield return new WaitForSeconds(UltAttackTimer);
       UltAttackCount = 0;
        Anim.SetBool("UltAttack", false);
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
        UltimateAttack();
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

        if (AttackCount == 1)
        {
            //Anim.SetBool("Attack1", false);
            StartCoroutine(ResetAttack1());

        }
    }


    void UltimateAttack()
    {
        if(Input.GetButtonDown("Fire2") && UltAttackCount == 0)
        {
           // RB.velocity = Vector2. * UltAttackSpeed;
            Anim.SetBool("UltAttack", true);
            UltAttackCount = 1;
            StartCoroutine(ResetUltAttack());
        }

    }
}
