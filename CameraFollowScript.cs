using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {
	public Transform target;
	public Transform target2;
	public float dampTime = .15f;
	private Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 point = GetComponent<Camera>().WorldToViewportPoint (target.position);
		Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, point.z));
		Vector3 destination = transform.position + delta;
		transform.position = Vector3.SmoothDamp (transform.position, destination, ref velocity, dampTime);
		/*List xPositions;
		List yPositions;
		for (Transform target && Transform target2) {
			xPositions.Add(target.x);
			yPositions.Add(target.y);
		}
		maxX = Max(xPositions);
		maxY = Max(yPositions);
		minX = Min(xPositions);
		minY = Min(yPositions);
		
		minPosition = Vector2(minX, minY)
			maxPosition = Vector2(minX, minY) */
	
	}
}

