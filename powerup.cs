using UnityEngine;
using System.Collections;

public class powerup : MonoBehaviour {
	private Rigidbody capsule;
	public bool active;
	public double timer=0;
	public int type;
	// Use this for initialization
	void Start () {
		capsule = this.GetComponent<Rigidbody> ();
		active = true;
		type = (int)(Random.value * 2);
	}
	
	// Update is called once per frame
	void Update () {
		if (active == false) {
			timer=timer+1;}

if (type == 0) {
type = (int)((Random.value+1) * 1);}

if (timer >= 1800) {
active=true;
			timer=0;}


	}
	void OnTriggerEnter(Collider other)
	{
		if (active == true&&(other.gameObject.GetComponent<Name>().name.Equals("Player1")||other.gameObject.GetComponent<Name>().name.Equals("Player3")||other.gameObject.GetComponent<Name>().name.Equals("Player2")||other.gameObject.GetComponent<Name>().name.Equals("Player4"))) {
			other.GetComponent<powerupactive> ().powerupnumber = type;
			active = false;
			type = 0;
		}

	}

}
