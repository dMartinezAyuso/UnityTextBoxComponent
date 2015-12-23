using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 0f;
	
	public bool canMove;
	public float moveHorizontal = 0f;

	private Rigidbody2D rgbd;	

	void Start() {
		rgbd = this.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
		if(!canMove) {
			rgbd.velocity = Vector3.zero;
			return;
		}

		moveHorizontal = Input.GetAxis ("Horizontal");		
		Vector2 velocityVector = rgbd.velocity;		
		velocityVector.x = moveHorizontal*speed;	
		rgbd.velocity = velocityVector;
	}

}
