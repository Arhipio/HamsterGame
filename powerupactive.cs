using UnityEngine;
using System.Collections;

public class powerupactive : MonoBehaviour {
	public int powerup;
	public double timer=0;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (powerup == 1) {
			 timer=timer+1;
		}
	}
}
