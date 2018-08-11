using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
	public float speed = 0.1f;
	int direction = 1;
	public int rightSide = 100;
	public int leftSide = 54;
	public int topSide = 20;
	public int bottomSide = 12;
	int direction2 = 1;
	
	// Use this for initialization
	void Start () {
		
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
		if (direction2 == 1) {
			MoveUp ();
		} else if (direction2 == -1) {
			MoveDown ();	
		}
		if ((direction2 == 1 && transform.position.y > topSide) || (direction2 == -1 && transform.position.y < bottomSide)) {
			ChangeDirection2 ();
		}
		
	}
	void ChangeDirection() {
		direction *= -1;
		Vector3 scale = transform.localScale;
		scale.x*=-1;
		transform.localScale = scale;
	}
	void ChangeDirection2() {
		direction2 *= -1;
		Vector3 scale = transform.localScale;
		scale.y*=-1;
		transform.localScale = scale;
	}
	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log ("Collision!!");
		DestroyObject (gameObject);
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
	void MoveUp() {
		if (direction2 == -1) {
			Vector3 scale = transform.localScale;
			scale.y*=-1;
			transform.localScale = scale;
			direction2 = 1;	
		}
		Vector3 position = transform.position;
		position.y += speed;
		transform.position = position;
		
	}
	void MoveDown() {
		if (direction2 == 1) {
			Vector3 scale = transform.localScale;
			scale.y*=-1;
			transform.localScale = scale;
			direction2 = -1;	
		}
		Vector3 position = transform.position;
		position.y -= speed;
		transform.position = position;
		
	}
}

