using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAlight : MonoBehaviour {
    Material colour;
	private Rigidbody2D rb2d;
	private AudioSource audioMessage;
	private bool triggered;
	// Use this for initialization
	void Awake () 
	{
		triggered = false;
		rb2d = GetComponent<Rigidbody2D>();
        colour = GetComponent<Renderer>().material;
		
	}
	
	void OnCollisionEnter2D (Collision2D other)
	  {
		  
		  if (triggered){
			  // do nothing
		  }
		   else if (other.gameObject.CompareTag("Player")){
			triggered = true;
			Alight();	
			PlaySound();
		  }
	}	
	 
	 void Alight ()
	  {
        colour.color = Color.yellow;
	  }
	  
	  	 void PlaySound ()
	  {
        audioMessage = GetComponent<AudioSource>();
        audioMessage.Play();
		
	}
	

}