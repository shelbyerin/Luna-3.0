using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PugAnimController : MonoBehaviour {

	private bool isGrounded = false;
	[HideInInspector] public bool jump = false;
	float jumpTime, jumpDelay = 0.5f;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Ground")) {
			isGrounded = true;
			jumpTime -= Time.deltaTime;
			if(jumpTime <= 0)
			{
				anim.SetTrigger("Land");
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			jump = true;
			anim.SetTrigger("Jump");
		}
	}

	void FixedUpdate()
	{
		anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

		//only allows right movement
		if (Input.GetKey(KeyCode.RightArrow))
		{
			if (jump && isGrounded)
			{
				jump = false;
				isGrounded = false;
				anim.SetTrigger("Jump");
			}
		}
	}
}
