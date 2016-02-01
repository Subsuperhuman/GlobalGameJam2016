using UnityEngine;
using System.Collections;

public class WaterBehaviours : MonoBehaviour {

	public float defaultLevel;

	public float maxLevel;

	private float level = 0;

	public Camera cam; 

	public float baseLevel;

	public float fillRate = 0.01f;

	private SeasonController seasonCtrl;

	private MeshRenderer meshRenderer;

	public Material springMat;
	public Material summerMat;
	public Material autumnMat;
	public Material winterMat;

	private BoxCollider2D box;

	// Use this for initialization
	void Start () {
		seasonCtrl = (SeasonController) FindObjectOfType (typeof(SeasonController));
		meshRenderer = GetComponent<MeshRenderer> ();
		box = GetComponent<BoxCollider2D> ();
		level = defaultLevel;
	}
	
	// Update is called once per frame
	void Update () {

		level = level;

		Vector3 newP;

		if (seasonCtrl.season == "spring") {
			meshRenderer.material = springMat;
			box.enabled =false;
		}
		if (seasonCtrl.season == "summer") {
			meshRenderer.material = summerMat;
			box.enabled =false;
		}
		if (seasonCtrl.season == "autumn") {
			meshRenderer.material = autumnMat;
			box.enabled =false;
		}
		if (seasonCtrl.season == "winter") {
			meshRenderer.material = winterMat;
			box.enabled =true;
		}



		if (seasonCtrl.season == "spring") {
			level += fillRate;
		} else if (seasonCtrl.season == "summer") {
			level -= 0.5f*fillRate;
		}

		if (level < baseLevel) {
			level = baseLevel;
		}

		if (level > maxLevel) {
			level = maxLevel;
		}


		newP.x = cam.transform.position.x;
		newP.y = level;
		newP.z = transform.position.z;

		transform.position = newP;
	
	}
}
