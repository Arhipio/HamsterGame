
using System.Collections;
using UnityEngine;
public class inputstate2 : MonoBehaviour
{
	public bool left;
	public bool down;
	public bool right;
	public bool up;
	public bool jump1;
	public bool left1;
	public bool down1;
	public bool right1;
	public bool jump;
	public bool up1;
	public bool jump2;
	public bool left2;
	public bool down2;
	public bool right2;
	public bool up2;
	public bool left3;
	public bool down3;
	public bool right3;
	public bool up3;
	public bool jump3;
	void Update () {
		up = Input.GetKey (KeyCode.W);
		right = Input.GetKey(KeyCode.D);
		left= Input.GetKey(KeyCode.A);
		down = Input.GetKey(KeyCode.S);
		jump = Input.GetKey(KeyCode.Space);
		up1 = Input.GetKey (KeyCode.I);
		right1 = Input.GetKey(KeyCode.L);
		left1= Input.GetKey(KeyCode.J);
		down1 = Input.GetKey(KeyCode.K);
		up2 = Input.GetKey (KeyCode.Keypad8);
		right2 = Input.GetKey(KeyCode.Keypad6);
		left2= Input.GetKey(KeyCode.Keypad4);
		down2 = Input.GetKey(KeyCode.Keypad5);
		up3 = Input.GetKey (KeyCode.UpArrow);
		right3 = Input.GetKey(KeyCode.RightArrow);
		left3= Input.GetKey(KeyCode.LeftArrow);
		down3 = Input.GetKey(KeyCode.DownArrow);

	}
	
	
	
}


