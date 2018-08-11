using UnityEngine;
using System.Collections;

public class Player2Controller : MonoBehaviour {
	public float horizontalSpeed = 1f;
	public float verticalSpeed = 1f;
	// Use this for initialization
	void Start () {
		Debug.Log ("Start");	
	}
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "goal") {
			Debug.Log ("Goal");
			Application.LoadLevel(1);
		}
		else if (col.gameObject.tag == "death") {
			Debug.Log ("Failed");
			Application.LoadLevel (Application.loadedLevel);
		}
		else if (col.gameObject.tag == "goal50") {
			Debug.Log ("Goal");
			Application.LoadLevel(2);
		}
		else if (col.gameObject.tag == "goal99") {
			Debug.Log ("Goal");
			Application.LoadLevel(3);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			MoveRight ();
		}
		else if (Input.GetKey (KeyCode.A)) {
			MoveLeft ();
		}	
		else if (Input.GetKeyDown (KeyCode.W)) {
			MoveUp ();
		}
	}
	void MoveRight () {
		Vector3 position = transform.position;
		position.x += horizontalSpeed;
		transform.position = position;
		Debug.Log ("MovingRight");
	}
	void MoveLeft () {
		Vector3 position = transform.position;
		position.x -= horizontalSpeed;
		transform.position = position;
		Debug.Log ("MovingLeft");
	}
	void MoveUp () {
		transform.GetComponent<Rigidbody2D>().AddForce (Vector2.up * verticalSpeed);
		
		Debug.Log ("MovingUp");
		
	}
	
}
