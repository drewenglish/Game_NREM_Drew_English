using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalDoorCollider : MonoBehaviour {


	bool triggered;

	// Use this for initialization
	void Start () 
	{
        triggered = false;		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D collider) 
	{
		if (! triggered)
		{
			if (collider.gameObject.layer == LayerMask.NameToLayer("Player"))
			{
				Trigger();
			}
	}
}

    void Trigger()
	{
	SceneManager.LoadScene(3);
	}

}