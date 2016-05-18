using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerName : MonoBehaviour {

	private GameObject text;
	private GameObject camera;
	private Text name;
	
	public string playerName;
	public Vector3 ballPosition;

	// Use this for initialization
	void Start () {
		text = GameObject.Find(playerName + "Text");
		name.text = playerName;
	}

	// Update is called once per frame
	void Update () {
		ballPosition = GameObject.Find (playerName + "HamsterBall").transform.position;
		text.transform.position = ballPosition + new Vector3(2.6f,0.5f,0.5f);
	}
}
