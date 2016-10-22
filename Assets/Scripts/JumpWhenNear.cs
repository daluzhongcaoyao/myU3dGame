using UnityEngine;
using System.Collections;

public class JumpWhenNear : MonoBehaviour {
	private GameObject m_Cube;
	private Transform m_Cube_Position;
	private Rigidbody m_Cube_Rigidbody;

	// Use this for initialization
	void Start () {
		m_Cube = GameObject.Find ("CubeOperate");
		m_Cube_Rigidbody = m_Cube.GetComponent<Rigidbody> ();
		m_Cube_Position = m_Cube.GetComponent<Transform> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider coll){


	}
}
