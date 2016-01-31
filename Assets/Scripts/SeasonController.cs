using UnityEngine;
using System.Collections;

public class SeasonController : MonoBehaviour {

	public string season = "spring";

	private bool seasonChange = false;
	private bool toggleSeason = false;

	private bool ritualInProgress = false;

	public bool RitualInProgress {
		get {
			return ritualInProgress;
		}
	}

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {

			startRitual();
			
		} else if(Input.GetKeyUp (KeyCode.Q)){

		}

		print (season);
	}

	public void changeSeason() {

		ritualInProgress = false;

		if (season == "spring") {
			season = "summer";
		} else if (season == "summer") {
			season = "autumn";
		} else if (season == "autumn") {
			season = "winter";
		} else if (season == "winter") {
			season = "spring";
		}

		seasonChange = false;
	}

	public void startRitual(){
		ritualInProgress = true;
	}
}
