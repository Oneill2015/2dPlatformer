using UnityEngine;
using System.Collections;

public class MovingBlocks : MonoBehaviour {
	public float speed = 0.1f;
	public int topSide = 20;
	public int bottomSide = 12;
	int direction2 = 1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (direction2 == 1) {
			MoveUp ();
		} else if (direction2 == -1) {
			MoveDown ();	
		}
		if ((direction2 == 1 && transform.position.y > topSide) || (direction2 == -1 && transform.position.y < bottomSide)) {
			ChangeDirection2 ();
		}
		
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


