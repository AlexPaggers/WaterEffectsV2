using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWater : MonoBehaviour {

	public GameObject waterParticle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) 
		{
			Instantiate(waterParticle, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), this.transform.localRotation);
		}
		if (Input.GetKey (KeyCode.F)) 
		{
			
		}
	}
}
