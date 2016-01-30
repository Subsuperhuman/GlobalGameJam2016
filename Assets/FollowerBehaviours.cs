using UnityEngine;
using System.Collections;

public class FollowerBehaviours : MonoBehaviour {

	private Animator m_Anim;
	private Rigidbody2D m_Rigidbody2D;

	private bool m_FacingRight = false;  // For determining which way the player is currently facing.

	public float offset;			// The offset at which the Health Bar follows the player.
	
	private Transform player;		// Reference to the player.
	
	public float followSpeed = 10;

	public float maxSpeed = 10;


	private void Awake()
	{
		// Setting up references.
		m_Anim = GetComponent<Animator>();
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
	}


	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player1").transform;
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (transform.position, player.position) > offset) {//move if distance from target is greater than 1
			float direction;
			
			if ((transform.position.x - player.position.x) > 0) {
				direction = -1;
			} else {
				direction = 1;
			}
			
			Move (direction * followSpeed * Time.deltaTime);

		} else {
			m_Anim.SetFloat("Speed", 0f);
		}
	
	}

	public void Move(float move)
	{

			// The Speed animator parameter is set to the absolute value of the horizontal input.
			m_Anim.SetFloat("Speed", Mathf.Abs(move));
			
			// Move the character
			m_Rigidbody2D.velocity = new Vector2(move*maxSpeed, m_Rigidbody2D.velocity.y);
			
			// If the input is moving the player right and the player is facing left...
			if (move > 0 && !m_FacingRight)
			{
				// ... flip the player.
				Flip();
			}
			// Otherwise if the input is moving the player left and the player is facing right...
			else if (move < 0 && m_FacingRight)
			{
				// ... flip the player.
				Flip();
			}
		
	}
	
	
	private void Flip()
	{
		// Switch the way the player is labelled as facing.
		m_FacingRight = !m_FacingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
