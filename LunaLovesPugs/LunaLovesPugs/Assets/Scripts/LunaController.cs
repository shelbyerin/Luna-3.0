using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LunaController : MonoBehaviour {

	[HideInInspector] public bool jump = false;
	public float moveForce = 365f;
	public float maxSpeed;
	public float jumpForce = 700f;
	public int xPOS;
	public int yPOS;
	private Rigidbody2D rb2d;
	public GameObject Luna;
	private bool isGrounded = false;
	float jumpTime, jumpDelay = 0.5f;
	bool jumped;

	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void Awake ()
	{
		rb2d = GetComponent<Rigidbody2D>();
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

	void Update ()
	{
		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			jump = true;
			anim.SetTrigger("Jump");
		}

		if (Luna.transform.position.y < -10)
		{
			LoadScene("GameOver");
		}
	}

	void FixedUpdate()
	{
		anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

		//only allows right movement
		if (Input.GetKey(KeyCode.RightArrow))
		{
			var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			transform.position += move * maxSpeed * Time.deltaTime;
			xPOS = (int)transform.position.x;
			if (jump && isGrounded)
			{
				rb2d.AddForce(new Vector2(0f, jumpForce));
				rb2d.gravityScale = 2.5f;
				jump = false;
				isGrounded = false;
				anim.SetTrigger("Jump");
			}
		}
		//makes it so they cannot move Left
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.position = transform.position;
		}
	}

	//Method Loads a scene by a given name encasped in quotes
	public void LoadScene(string sceneName)
	{
			SceneManager.LoadScene(sceneName);
	}
}
