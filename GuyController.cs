using UnityEngine;
using System.Collections;

public class GuyController : MonoBehaviour {
	public float speed = 0.1f;
	public GameObject bullet;
	int direction = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			MoveRight();		
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			MoveLeft();		
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			FireBullet();		
		}
	
	}
	void FireBullet() {
		Instantiate (bullet, transform.position, Quaternion.identity);
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
