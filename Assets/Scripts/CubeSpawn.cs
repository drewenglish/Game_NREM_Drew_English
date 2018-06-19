using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour {
	public float spawnTime = 5f;            // How long between each spawn.

	public int maxPlatforms = 5;
	public GameObject Cube;
	public GameObject Cube2;
	public GameObject Cube3;
	public GameObject Cube4;
	public GameObject Cube5;
	public GameObject Cube6;
	public GameObject Cube7;
	public GameObject Cube8;
	public GameObject Cube9;
	public GameObject Cube10;
	public GameObject Cube11;
	public GameObject Cube12;


	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -6f;
	public float verticalMax = 6f;
	
	private Vector2 originPosition;
	
	// Use this for initialization
	public void Start () 
	{
		originPosition = transform.position;
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	// Update is called once per frame
	public void Spawn ()
	{
		for (int i = 0; i < maxPlatforms; i++)
		{
			Vector2 randomPosition =  originPosition + new Vector2 (Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
			
			Instantiate(getRandomCube(), randomPosition, Quaternion.identity);
		}
	}
	 public GameObject getRandomCube(){
		
		int rand = Random.Range(1,12);
		
		if (rand == 1){
			return Cube;
		} else if (rand == 2){
			return Cube2;
		} else if (rand ==3) {
			return Cube3;
		} else if (rand == 4){
			return Cube4;
		} else if (rand == 5){
			return Cube5;
		} else if (rand == 6){
			return Cube6;
		} else if (rand == 7){
			return Cube7;
		} else if (rand == 8) {
			return Cube8;
		} else if (rand == 9) {
			return Cube9;
		} else if (rand == 10) {
			return Cube10;
		} else if (rand == 11){
			return Cube11;
		} else if (rand == 12) {
			return Cube12;
		} else{
			return Cube;
		}
	}
}
