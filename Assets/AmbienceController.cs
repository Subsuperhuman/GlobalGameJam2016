using UnityEngine;
using System.Collections;

public class AmbienceController : MonoBehaviour {

	AudioSource source;

	AudioClip clip;

	public AudioClip springAmbience;
	public AudioClip summerAmbience;
	public AudioClip autumnAmbience;
	public AudioClip winterAmbience;

	private SeasonController seasonCtrl;

	// Use this for initialization
	void Start () {
		seasonCtrl = (SeasonController) FindObjectOfType (typeof(SeasonController));
		source = GetComponent<AudioSource> ();
		clip = GetComponent<AudioClip> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (seasonCtrl.season == "spring") {
			source.clip = springAmbience;
		}
		if (seasonCtrl.season == "summer") {
			source.clip = summerAmbience;
		}
		if (seasonCtrl.season == "autumn") {
			source.clip = autumnAmbience;
		}
		if (seasonCtrl.season == "winter") {
			source.clip = winterAmbience;
		}
	}
}
