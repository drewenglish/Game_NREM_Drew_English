using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCubeRepel : MonoBehaviour {
    Material colour;
	private BoxCollider2D box;
	private AudioSource audioMessage;
	private bool triggered;
	// Use this for initialization
	void Awake () 
	{		box = GetComponent<BoxCollider2D>();		
	}
	
	void OnCollisionEnter2D (Collision2D other)
	  {
		  
		if (other.gameObject.CompareTag("Player")){
			// do nothing
		  } else{
			  Destroy(other.gameObject);
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