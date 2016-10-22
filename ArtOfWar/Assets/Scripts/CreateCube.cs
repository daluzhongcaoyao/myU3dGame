using UnityEngine;
using System.Collections;

public class CreateCube : MonoBehaviour {
	public GameObject GoldBox;

	// Use this for initialization
	void Start () {
		CreateGoldBox ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void CreateGoldBox(){

		//GameObject.Instantiate(GoldBox, position, Quaternion.identity);
		int i = 0;
		int j = 0;
		for(i=0; i<2; i++){
			for (j=0;j<2;j++){
				Vector3 CreatePosition = new Vector3(10,j*5,20);
				GameObject.Instantiate(GoldBox, CreatePosition, Quaternion.identity);
			}
		}
	}
}
