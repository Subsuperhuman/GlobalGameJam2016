using UnityEngine;
using System.Collections;

public class SkyController : MonoBehaviour {

	public Material springMat;
	public Material summerMat;
	public Material autumnMat;
	public Material winterMat;

	private SeasonController seasonCtrl;
	
	private MeshRenderer meshRenderer;

	// Use this for initialization
	void Start () {
		seasonCtrl = (SeasonController) FindObjectOfType (typeof(SeasonController));
		meshRenderer = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (seasonCtrl.season == "spring") {
			meshRenderer.material = springMat;
		}
		if (seasonCtrl.season == "summer") {
			meshRenderer.material = summerMat;
		}
		if (seasonCtrl.season == "autumn") {
			meshRenderer.material = autumnMat;
		}
		if (seasonCtrl.season == "winter") {
			meshRenderer.material = winterMat;
		}
	
	}
}
