using UnityEngine;
using System.Collections;

/*All assests made by me, with exception to:
main character (http://opengameart.org/sites/default/files/styles/watermarked/public/lpc-art/professor_walk_cycle_no_hat.png)
fireball (http://opengameart.org/sites/default/files/styles/watermarked/public/fireball_0.png)
Skybox in Level 3 (not used)(http://dreamatico.com/data_images/cloud/cloud-7.jpg)
Level2 Pictures (http://assets.worldwildlife.org/photos/2842/images/hero_small/shutterstock_12730534.jpg?1352150501, http://4.bp.blogspot.com/-9fn07cNR2ZQ/TrCeKcIqy0I/AAAAAAAAANw/ueQ3cGiEgIo/s1600/underwatercaves.jpg)
 Castle walls of Level 4 (http://www.smwcentral.net/?p=viewthread&t=40835)
enemy animation (http://www.remcodraijer.nl/quintus/images/player.png)
FinalCastle (data:image/png;base64,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)
Knight in Level 6 (http://art.devsader.com/content/contributions/sprites/JacobKnight_Moosader.png)
Level3BlueBird (http://www.wikitude.com/documents/13703/33389/bird.png?t=1344496407077)
Snake Enemies (http://www.spriters-resource.com/resources/sheets/54/57053.png)
Level1Music (K:\Courses\2015-Spring\ITC383-morel1a\Assets\sonniss\Mechanical Wave - Ambience and Weather)
Level2Music (K:\Courses\2015-Spring\ITC383-morel1a\Assets\sonniss\Alexander Kopeikin - Moscow Ambience)
Level3Music (K:\Courses\2015-Spring\ITC383-morel1a\Assets\sonniss\Varazuvi - Natural Environments)
Level4Music (K:\Courses\2015-Spring\ITC383-morel1a\Assets\sonniss\SoundMorph - Doom Drones)
Level5Music (K:\Courses\2015-Spring\ITC383-morel1a\Assets\sonniss\SoundMorph - Doom Drones)
Level6Music (K:\Courses\2015-Spring\ITC383-morel1a\Assets\sonniss\SoundMorph - Doom Drones)
 */
public class PlayerController : MonoBehaviour {
	public float horizontalSpeed = 1f;
	public float verticalSpeed = 1f;
	int direction = 1;
	public GameObject bullet;
	public bool powerup = false;
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
		else if (col.gameObject.tag == "goal100") {
			Debug.Log ("Goal");
			Application.LoadLevel(4);
		}
		else if (col.gameObject.tag == "goal101") {
			Debug.Log ("Goal");
			Application.LoadLevel(5);
		}
		else if (col.gameObject.tag == "endgametag") {
			Debug.Log ("Goal");
			Application.LoadLevel(6);
		}
		else if (col.gameObject.tag == "powerup") {
			Debug.Log ("Shoot");
			powerup = true;
		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			MoveRight ();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			MoveLeft ();
		}	
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			MoveUp ();
		}
		if (Input.GetKeyDown(KeyCode.Space)){
			Shoot();
		}
	}
	void MoveRight () {
		if (direction == -1) {
			Vector3 scale = transform.localScale;
			scale.x*=-1;
			transform.localScale = scale;
			direction = 1;	
		}
		Vector3 position = transform.position;
		position.x += horizontalSpeed;
		transform.position = position;
		Debug.Log ("MovingRight");
	}
	void MoveLeft () {
		if (direction == 1) {
			Vector3 scale = transform.localScale;
			scale.x*=-1;
			transform.localScale = scale;
			direction = -1;	
		}
		Vector3 position = transform.position;
		position.x -= horizontalSpeed;
		transform.position = position;
		Debug.Log ("MovingLeft");
	}
	void MoveUp () {
		transform.GetComponent<Rigidbody2D>().AddForce (Vector2.up * verticalSpeed);

		Debug.Log ("MovingUp");

	}
	void Shoot(){
		if (powerup == true) {
						Instantiate (bullet, transform.position, Quaternion.identity);
				}
		
	}

}
