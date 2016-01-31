using UnityEngine;
using System.Collections;

[RequireComponent(typeof (SeasonController))]

public class TreeBehaviours : MonoBehaviour {

	private SeasonController seasonCtrl;
	private SpriteRenderer sp;

	public Sprite springTree;
	public Sprite summerTree;
	public Sprite autumnTree;
	public Sprite winterTree;


	// Use this for initialization
	void Start () {

		sp = GetComponent<SpriteRenderer>();
		seasonCtrl = (SeasonController) FindObjectOfType (typeof(SeasonController));
	
	}
	
	// Update is called once per frame
	void Update () {

		if (seasonCtrl.season == "spring") {
			sp.sprite = springTree;
		}
		if (seasonCtrl.season == "summer") {
			sp.sprite = summerTree;
			print ("summer tree!");
		}
		if (seasonCtrl.season == "autumn") {
			sp.sprite = autumnTree;
		}
		if (seasonCtrl.season == "winter") {
			sp.sprite = winterTree;
		}
	
	}
}
