using UnityEngine;
using System.Collections;

public class powerupactive : MonoBehaviour {
	public int powerupnumber;
	public double timer=0;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (powerupnumber == 1) {
			 timer=timer+1;
			if(timer>6000){powerupnumber=0;
				timer=0;}

		}
	}
}
