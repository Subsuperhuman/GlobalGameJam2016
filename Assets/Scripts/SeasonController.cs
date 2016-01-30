using UnityEngine;
using System.Collections;

public class SeasonController : MonoBehaviour {

	public string season = "spring";

	private bool seasonChange = false;
	private bool toggleSeason = false;


	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		if (!Input.GetKeyDown (KeyCode.Q)) {
			toggleSeason = false;
		}

		if (Input.GetKeyDown (KeyCode.Q) && !toggleSeason) {
			toggleSeason = true;
			seasonChange = true;
		}

		if (seasonChange) {
			changeSeason();
		}
		
	}

	void changeSeason() {

		if (season == "spring") {
			season = "summer";
		} else if (season == "summer") {
			season = "autumn";
		} else if (season == "autumn") {
			season = "winter";
		} else if (season == "winter") {
			season = "spring";
		}

		print (season);

		seasonChange = false;
	}
}
