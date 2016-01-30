using UnityEngine;
using System.Collections;

public class WaterBehaviours : MonoBehaviour {

	public float defaultLevel;

	private float level = 0;

	public Camera cam; 

	public float baseLevel;

	public float fillRate = 0.01f;

	private SeasonController seasonCtrl;

	// Use this for initialization
	void Start () {
		seasonCtrl = (SeasonController) FindObjectOfType (typeof(SeasonController));
	}
	
	// Update is called once per frame
	void Update () {

		level = level;

		Vector3 newP;

		if (seasonCtrl.season == "spring") {
			level += fillRate;
		} else if (seasonCtrl.season == "summer") {
			level -= 0.5f*fillRate;
		}

		if (level < baseLevel) {
			level = baseLevel;
		}


		newP.x = cam.transform.position.x;
		newP.y = defaultLevel + level + baseLevel;
		newP.z = transform.position.z;

		transform.position = newP;
	
	}
}
