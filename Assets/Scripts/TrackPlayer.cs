using UnityEngine;
using System.Collections;

public class TrackPlayer : MonoBehaviour {

	public Vector3 offset;			// The offset at which the Health Bar follows the player.

	public float parallax;
	
	private Transform player;		// Reference to the player.

	// Use this for initialization
	void Start () {
		// Setting up the reference.
		player = GameObject.Find("Main Camera").transform;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 position = transform.position;

		Vector3 newPos = position;

		float parallaxOffset = player.position.x / parallax;

		newPos.x = player.position.x + offset.x - parallaxOffset;

		transform.position = newPos;

	}
}
