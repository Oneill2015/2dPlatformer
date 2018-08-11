using UnityEngine;
using System.Collections;

public class CraftyController : MonoBehaviour {
	public float speed = 0.1f;
	int direction = 1;
	public int rightSide = 10;
	public int leftSide = -10;

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
	
	}
	void ChangeDirection() {
		direction *= -1;
		Vector3 scale = transform.localScale;
		scale.x*=-1;
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
}
