using UnityEngine;
using System.Collections;

public class MapTime : MonoBehaviour {
	public double maptime=0;
	public Rigidbody floor;
	// Use this for initialization
	void Start () {
		floor = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		maptime = maptime + (0.01666666666);
		if (maptime >10) {
			floor.constraints &= ~RigidbodyConstraints.FreezePositionY;
			floor.velocity= new Vector3(0,1,0);
		}
	}
}
