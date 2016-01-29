using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public float offset;			// The offset at which the Health Bar follows the player.
	
	private Transform player;		// Reference to the player.

	public float followSpeed;


	void Awake ()
	{
		// Setting up the reference.
		player = GameObject.Find("Player1").transform;
	}

	void Update ()
	{
		//rotate to look at the player
		//transform.LookAt(player.position);
		//transform.Rotate(new Vector3(0,-90,0),Space.Self);//correcting the original rotation
		
		
		//move towards the player
		if (Vector3.Distance(transform.position,player.position)>offset){//move if distance from target is greater than 1
			float direction;

			if((transform.position.x - player.position.x) > 0)
			{
				direction = -1;
			}
			else
			{
				direction = 1;
			}

			transform.Translate(new Vector3(direction*followSpeed* Time.deltaTime,0,0) );
		}
	}
}
