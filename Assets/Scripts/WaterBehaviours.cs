using UnityEngine;
using System.Collections;

public class WaterBehaviours : MonoBehaviour {

	public float defaultLevel;

	private float level = 0;

	public Camera cam; 

	public float baseLevel;

	// Use this for initialization
	void Start () {;
	}
	
	// Update is called once per frame
	void Update () {

		level = level;

		Vector3 newP;



		newP.x = cam.transform.position.x;
		newP.y = defaultLevel + level + baseLevel;
		newP.z = transform.position.z;

		transform.position = newP;
	
	}
}
