using UnityEngine;
using System.Collections;

public class Deaths : MonoBehaviour {
	private string tag;
	private AudioSource horn;

	void Start(){
		horn = GameObject.Find ("Airhorn").GetComponent<AudioSource> ();
	}
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		tag = other.gameObject.name.Substring(0,2);
		Destroy (GameObject.Find(tag+"Image"));
		StartCoroutine(Audio ());
	}

	private IEnumerator Audio() {
		horn.Play();
		GameObject.Find ("Flames").GetComponent<ParticleSystem>().Play ();
		GameObject.Find ("Flames 1").GetComponent<ParticleSystem>().Play ();
		GameObject.Find ("Confetti").GetComponent<ParticleSystem>().Play ();
		GameObject.Find ("Confetti 1").GetComponent<ParticleSystem>().Play ();
		yield return new WaitForSeconds(3f);
		horn.Stop();
		yield return null;
	}
}
