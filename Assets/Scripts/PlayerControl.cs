using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	private Transform m_Transform;
	private Rigidbody m_Rigidbody;
	public GameObject PrefabGold;

	// Use this for initialization
	void Start () {
		Debug.Log ("onCreate1");
		m_Transform = gameObject.GetComponent<Transform> ();
		m_Rigidbody = gameObject.GetComponent<Rigidbody> ();
			
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.W)) {
			m_Rigidbody.MovePosition(m_Transform.position + Vector3.forward * 0.5f);
		}
		if (Input.GetKey(KeyCode.A)) {
			m_Rigidbody.MovePosition(m_Transform.position + Vector3.left * 0.5f);
		}
		if (Input.GetKey(KeyCode.S)) {
			m_Rigidbody.MovePosition(m_Transform.position + Vector3.back * 0.5f);
		}
		if (Input.GetKey(KeyCode.D)) {
			m_Rigidbody.MovePosition(m_Transform.position + Vector3.right * 0.5f);
		}
		if (Input.GetKey(KeyCode.Space)) {
			m_Rigidbody.MovePosition(m_Transform.position + Vector3.up * 0.5f);
		}
	}

	void OnCollisionEnter(Collision coll){
		if(coll.gameObject.tag == "GoldBox"){
			Debug.Log ("create gold");
			GameObject.Destroy(coll.gameObject);
			GameObject.Instantiate(PrefabGold,
			                       coll.gameObject.GetComponent<Transform>().position + Vector3.up * 10f, 
			                       Quaternion.identity);
		}
	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag == "Gold") {
			GameObject.Destroy(coll.gameObject);
			GameObject.Find("Score").gameObject.SendMessage("addScore");	
		}
	}





}
