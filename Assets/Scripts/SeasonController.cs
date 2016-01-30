using UnityEngine;
using System.Collections;

public class SeasonController : MonoBehaviour {

	public string season = "spring";

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Q)) {
			season = "summer";
		}
		
	}
}
