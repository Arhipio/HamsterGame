using UnityEngine;
using System.Collections;

public class Deaths : MonoBehaviour {
	private string tag;

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}
}
