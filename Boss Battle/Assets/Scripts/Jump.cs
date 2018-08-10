using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Jump : MonoBehaviour {

    #region Variables
    public float JumpForce;
    private Rigidbody2D RB;
    private bool IsGrounded;
    public Transform GroundCheck;
    public float CheckRadius;
    public LayerMask WhatIsGround;
    private int ExtraJumps;
    public int ExtraJumpsValue;
    private Animator Anim;
    #endregion

    // Use this for initialization
    void Start () {
        RB = GetComponent<Rigidbody2D>();
        ExtraJumps = ExtraJumpsValue;
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if(IsGrounded == true)
        {
            ExtraJumps = ExtraJumpsValue;
            Anim.SetBool("DoubleJump", false);
        }

        if (Input.GetButtonDown("Jump") && ExtraJumps > 0)
        {
            RB.velocity = Vector2.up * JumpForce;
            ExtraJumps--;
            Anim.SetBool("DoubleJump", true);
        }else if (Input.GetButtonDown("Jump") && ExtraJumps == 0 && IsGrounded == true)
        {
            RB.velocity = Vector2.up * JumpForce;
           // Anim.SetBool("DoubleJump", false);
        }
	}

    private void FixedUpdate()
    {
        IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, CheckRadius, WhatIsGround);

    }
}
