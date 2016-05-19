using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	private float ovx;
	private float ovy;
	private float ovz;
	public float collisionforce;
	public double timer=30;
	public bool worked;
	private Rigidbody body;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer + 1;
	}
	void OnTriggerEnter(Collider other){
		if (other.GetComponent<powerupactive> ().powerupnumber == 1&&(other.GetComponent<Name> ().name.Equals ("Player2")||other.GetComponent<Name> ().name.Equals ("Player3")||other.GetComponent<Name> ().name.Equals ("Player4"))&&timer>15) {
			ovx = other.GetComponent<Rigidbody> ().velocity.x;
			ovy = other.GetComponent<Rigidbody> ().velocity.y;
			ovz = other.GetComponent<Rigidbody> ().velocity.z;
			this.GetComponent<Rigidbody> ().velocity = new Vector3 (ovx*collisionforce, 0, ovz*collisionforce);
		}
		else if ((other.GetComponent<Name> ().name.Equals ("Player2")||other.GetComponent<Name> ().name.Equals ("Player3")||other.GetComponent<Name> ().name.Equals ("Player4"))&&timer>15) {
			ovx = other.GetComponent<Rigidbody> ().velocity.x;
			ovy = other.GetComponent<Rigidbody> ().velocity.y;
			ovz = other.GetComponent<Rigidbody> ().velocity.z;
			other.GetComponent<Rigidbody> ().velocity = new Vector3 (body.velocity.x*collisionforce,0, body.velocity.z*collisionforce);
			this.GetComponent<Rigidbody> ().velocity = new Vector3 (ovx*collisionforce, 0, ovz*collisionforce);
			timer=0;
			worked=true;

		}
	}
}
