using UnityEngine;
using System.Collections;

public class AmbienceController : MonoBehaviour {

	AudioSource source;

	AudioClip clip;

	public AudioSource springAmbience;
	public AudioSource summerAmbience;
	public AudioSource autumnAmbience;
	public AudioSource winterAmbience;

	private SeasonController seasonCtrl;

	// Use this for initialization
	void Start () {
		seasonCtrl = (SeasonController) FindObjectOfType (typeof(SeasonController));
		source = GetComponent<AudioSource> ();
		clip = GetComponent<AudioClip> ();
	}
	
	// Update is called once per frame
	void Update () {

		bool anyPlaying = springAmbience.isPlaying || summerAmbience.isPlaying || autumnAmbience.isPlaying || winterAmbience.isPlaying;

		if (seasonCtrl.season == "spring") {

			if(!springAmbience.isPlaying)
			{
				springAmbience.Play();
				summerAmbience.Stop ();
				autumnAmbience.Stop();
				winterAmbience.Stop ();
			}
		}
		if (seasonCtrl.season == "summer") {

			if(!summerAmbience.isPlaying)
			{
				springAmbience.Stop ();
				summerAmbience.Play ();
				autumnAmbience.Stop();
				winterAmbience.Stop ();
			}
		}
		if (seasonCtrl.season == "autumn") {

			if(!autumnAmbience.isPlaying)
			{
				springAmbience.Stop();
				summerAmbience.Stop ();
				autumnAmbience.Play();
				winterAmbience.Stop ();
			}
		}
		if (seasonCtrl.season == "winter") {

			if(!winterAmbience.isPlaying)
			{
				springAmbience.Stop();
				summerAmbience.Stop ();
				autumnAmbience.Stop();
				winterAmbience.Play ();
			}
		}
	}
}
