using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class player_fall_control : MonoBehaviour {
 
[HideInInspector] public bool facingRight = true;
	
    private Animator anim;
    
	private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetTrigger("Fall");
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		float h = Input.GetAxis("Horizontal");
		
		
		if ( h > 0 && !facingRight){
			Flip ();
		}else if ( h < 0 && facingRight){
			Flip ();
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
