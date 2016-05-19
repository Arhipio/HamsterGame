using UnityEngine;
namespace UnityStandardAssets.Vehicles.Ball	
{
	public class custommove1 : MonoBehaviour 
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
			if (inputState2.down1) {
				m_Rigidbody.AddTorque(new Vector3(-30000000, 0, 0)*m_MovePower);
			} 
			if (inputState2.up1) {
				
				
				m_Rigidbody.AddTorque(new Vector3(30000000, 0, 0)*m_MovePower);
			} 
			if (inputState2.left1) {
				m_Rigidbody.AddTorque(new Vector3(0, 0,30000000 )*m_MovePower);
				
			} 
			if (inputState2.right1) {
				m_Rigidbody.AddTorque(new Vector3(0, 0, -30000000)*m_MovePower);
			} 
		}}}