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
		seasonCtrl = GameObject.Find ("Seasons").GetComponent<SeasonController>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (seasonCtrl.season == "spring") {
			sp.sprite = springTree;
		}
		if (seasonCtrl.season == "summer") {
			print ("summer bitches");
			sp.sprite = summerTree;
		}
		if (seasonCtrl.season == "autumn") {
			sp.sprite = autumnTree;
		}
		if (seasonCtrl.season == "winter") {
			sp.sprite = winterTree;
		}
	
	}
}
