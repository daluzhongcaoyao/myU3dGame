using UnityEngine;
using System.Collections;

public class Gold : MonoBehaviour {
	private Transform m_Transform;

	// Use this for initialization
	void Start () {
		m_Transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		m_Transform.Rotate (Vector3.forward, 10f);
	}

	void OnTriggerEnter(Collider coll){
		if(coll.gameObject.name == "Player"){
			GameObject.Destroy(this.gameObject);
			GameObject.Find("Score").SendMessage("addScore");
		}
	}
}
