using UnityEngine;
using System.Collections;

public class multipleAnimations : MonoBehaviour

{
	public float speed = 10f;
	
	private Animator animator;
	
	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update()
	{
		

		if (Input.GetKey(KeyCode.UpArrow))
		{
			animator.SetInteger("Direction", 2);
			MoveUp ();
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			animator.SetInteger("Direction", 0);
			MoveDown ();
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			animator.SetInteger("Direction", 3);
			MoveRight();
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			animator.SetInteger("Direction", 1);
			MoveLeft ();

		}
		else if (Input.GetKey(KeyCode.P))
		{
			animator.SetInteger("Direction", 5);
			MoveLeft ();
			
		}
	}
	void MoveRight(){

		Vector3 position = transform.position;
		position.x += speed;
		transform.position = position;
		
	}
	void MoveLeft(){

		Vector3 position = transform.position;
		position.x -= speed;
		transform.position = position;
	}
	void MoveUp(){

		Vector3 position = transform.position;
		position.y += speed;
		transform.position = position;
	}
	void MoveDown(){

		Vector3 position = transform.position;
		position.y -= speed;
		transform.position = position;
	}

}
