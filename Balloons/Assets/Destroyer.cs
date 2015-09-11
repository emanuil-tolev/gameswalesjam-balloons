using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("Something");
		GameObject.Destroy (other.gameObject);
	}
}
