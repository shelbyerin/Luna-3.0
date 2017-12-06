using UnityEngine;
using System.Collections;

public class LunaController : MonoBehaviour {

	[HideInInspector] public bool jump = false;
	public float moveForce = 365f;
	public float maxSpeed;
	public float jumpForce = 700f;
	public int xPOS;
	private Rigidbody2D rb2d;

	void Awake ()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
	}

	void FixedUpdate()
	{
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * maxSpeed * Time.deltaTime;
		xPOS = (int)transform.position.x;

		if (jump)
		{
			rb2d.AddForce(new Vector2(0f, jumpForce));
			jump = false;
		}
	}
}
