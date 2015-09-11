using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour 
{
	public Transform objectToFollow;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (objectToFollow)
		{
			transform.position = objectToFollow.position + offset;
		}
	}
}
