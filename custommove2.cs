﻿using UnityEngine;
namespace UnityStandardAssets.Vehicles.Ball	
{
	public class custommove2 : MonoBehaviour 
	{
		[SerializeField] private float m_MovePower = 5;
		private inputstate2 inputState2;
		[SerializeField] private float m_MaxAngularVelocity = 25; // The maximum velocity the ball can rotate at.
		private Rigidbody m_Rigidbody;
		// Use this for initialization
		void Start () {
			m_Rigidbody = GetComponent<Rigidbody>();
			inputState2 =GetComponent<inputstate2> ();
			GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
		}
		
		// Update is called once per frame
		void Update () {
			if (inputState2.left3) {
				m_Rigidbody.AddTorque(new Vector3(-30000000, 0, 0)*m_MovePower);
			} 
			if (inputState2.right3) {
				
				
				m_Rigidbody.AddTorque(new Vector3(30000000, 0, 0)*m_MovePower);
			} 
			if (inputState2.up3) {
				m_Rigidbody.AddTorque(new Vector3(0, 0,30000000 )*m_MovePower);
				
			} 
			if (inputState2.down3) {
				m_Rigidbody.AddTorque(new Vector3(0, 0, -30000000)*m_MovePower);
			} 
		}
	}
}
