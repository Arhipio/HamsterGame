using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerName : MonoBehaviour {

	private GameObject text;
	private GameObject camera;
	private Text name;

	public Vector3 ballPosition;

	// Use this for initialization
	void Start () {
		text = GameObject.Find("Text");
	}

	// Update is called once per frame
	void Update () {
		ballPosition = GameObject.Find ("HamsterBall").transform.position;
		text.transform.position = ballPosition + new Vector3(0.8f,0.7f,0.7f);
	}
}
