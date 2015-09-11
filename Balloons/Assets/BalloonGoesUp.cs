using UnityEngine;
using System.Collections;

public class BalloonGoesUp : MonoBehaviour
{
	public float upSpeed = 0.02f;
	public float moveSpeed = 0.01f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 pos = transform.position;

		pos.y += upSpeed;

		pos.x += Input.GetAxis("Horizontal") * moveSpeed;

		
		transform.position = pos;
	}
}
