using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class simple_platform_controller : MonoBehaviour {

    [HideInInspector] public bool facingRight = true;
	[HideInInspector] public bool jump = false;
	
	public float moveForce = 365000000000f;
	public float maxSpeed = 5f;
	public float jumpForce = 5000f;
	public Transform groundCheck;
	
    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;
	private spawnManager spawn;
	private float playerEndGamePosition;
	//private float deathFall;
	
	// Use this for initialization
	void Start() 
	{
		playerEndGamePosition = transform.position.y - 80f;
	    anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
		//deathFall = transform.position.y - 30f;
	}
	
	// Update is called once per frame
	void Update() 
	
	{
		if (Input.GetKey("escape"))
            Application.Quit();
		
		
	    grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));	
		
		if (Input.GetButtonDown("Jump") && grounded)
		{
			jump = true;
		}
		 
		// if (transform.position.y > deathFall)
		// {
		//	 anim.SetTrigger("Fall");
		 
		
		if (transform.position.y < playerEndGamePosition)
		{			
			SceneManager.LoadScene(2);
		}
	
	     //print (rb2d.velocity.y);
		 
		
	}
	
	
	void FixedUpdate()
	{
		
		float h = Input.GetAxis("Horizontal");
		float v = rb2d.velocity.y;

		anim.SetFloat("HorizontalSpeed", Mathf.Abs(h));
		anim.SetFloat("VerticalSpeed", Mathf.Abs(v));

		if (h * rb2d.velocity.x < maxSpeed)
			rb2d.AddForce(Vector2.right * h * moveForce);

		
		if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
			rb2d.velocity = new Vector2(Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
		
		if ( h > 0 && !facingRight){
			Flip ();
		}else if ( h < 0 && facingRight){
			Flip ();
		}
		if (jump)
		{ 
	        anim.SetTrigger("Jump");
			rb2d.AddForce( new Vector2(0f, jumpForce));
			jump = false;
		}
		
	}
	
	
	
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
    }
}

