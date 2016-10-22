using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	void OnEnable(){
		Invoke ("DestoryBullet", 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DestoryBullet(){
		GameObject.Destroy (this.gameObject);
	}
}
