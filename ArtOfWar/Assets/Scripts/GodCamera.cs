using UnityEngine;
using System.Collections;

public class GodCamera : MonoBehaviour {
	private Ray ray;
	private RaycastHit hit;
	private Transform mTransform;
	public GameObject prefabBullet;

	// Use this for initialization
	void Start () {
		mTransform = Camera.main.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit)){
				GameObject go = GameObject.Instantiate(prefabBullet, mTransform.position,Quaternion.identity) as GameObject;
				Vector3 dir = hit.point - mTransform.position;
				go.GetComponent<Rigidbody>().AddForce(dir * 100);
			}
		}
	}
}
