using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerAttack : MonoBehaviour {


    #region MyVariables
    private Animator Anim;
    public int AttackCount = 0;
    public float Attack1Timer;
    #endregion


    IEnumerator ResetAttack1()
    {
        yield return new WaitForSeconds(Attack1Timer);
        AttackCount = 0;
        Anim.SetBool("Attack1", false);
       // Anim.SetBool("Idle", true);

    }
	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1") && AttackCount == 0)
        {
            Anim.SetBool("Attack1", true);
           // Anim.SetBool("Idle", false);
            AttackCount = 1;

        }
        
        if(AttackCount == 1)
        {
            
            StartCoroutine(ResetAttack1());

        }
	}

}
