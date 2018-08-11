using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public float speed = 0.1f;
	int direction = 1;
	public int rightSide = 100;
	public int leftSide = 54;

	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "bullet") {
			DestroyObject (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (direction == 1) {
			MoveRight ();
		} else if (direction == -1) {
			MoveLeft ();	
		}
		if ((direction == 1 && transform.position.x > rightSide) || (direction == -1 && transform.position.x < leftSide)) {
			ChangeDirection ();
		}

		
	}
	void ChangeDirection() {
		direction *= -1;
		Vector3 scale = transform.localScale;
		scale.x*=-1;
		transform.localScale = scale;
	}


	void MoveRight() {
		if (direction == -1) {
			Vector3 scale = transform.localScale;
			scale.x*=-1;
			transform.localScale = scale;
			direction = 1;	
		}
		Vector3 position = transform.position;
		position.x += speed;
		transform.position = position;
		
	}
	void MoveLeft() {
		if (direction == 1) {
			Vector3 scale = transform.localScale;
			scale.x*=-1;
			transform.localScale = scale;
			direction = -1;	
		}
		Vector3 position = transform.position;
		position.x -= speed;
		transform.position = position;
		
	}

}

