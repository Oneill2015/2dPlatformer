using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		position.x += speed;
		transform.position = position;
		StartCoroutine (DestroyInThreeSeconds ());


	
	}
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "death") {
			DestroyObject (gameObject);
		}
	
	}
	IEnumerator DestroyInThreeSeconds(){
		yield return new WaitForSeconds(3.0f);
		DestroyObject (gameObject);
		
	}
}
/*void Update () {
	if (!deleting) {
		
		
		if (transform.rotation.z > 0.7f || transform.rotation.z < -0.7f) {
			StartCoroutine (DestroyInThreeSeconds ());
			deleting = true;
		}
	}
	
}*/


