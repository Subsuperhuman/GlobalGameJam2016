using UnityEngine;
using System.Collections;

public class WaterSurfaceController : MonoBehaviour {

	private Animator anim;

	private SeasonController seasonCtrl;



	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
		seasonCtrl = (SeasonController) FindObjectOfType (typeof(SeasonController));

		anim.SetInteger("Season", 0);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (seasonCtrl.season == "spring") {
			anim.SetInteger("Season", 0);

		}
		if (seasonCtrl.season == "summer") {
			anim.SetInteger("Season", 1);
		}
		if (seasonCtrl.season == "autumn") {
			anim.SetInteger("Season", 2);
		}
		if (seasonCtrl.season == "winter") {
			anim.SetInteger("Season", 3);
		}
	
	}
}
