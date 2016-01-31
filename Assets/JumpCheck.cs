using UnityEngine;
using System.Collections;



public class JumpCheck : MonoBehaviour {

	public Rigidbody2D rBody;

	public float vForce = 200f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		rBody.AddForce (new Vector2 (0f, vForce));
	}
}
