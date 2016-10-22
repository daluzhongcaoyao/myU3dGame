using UnityEngine;
using System.Collections;

public class CreateCube : MonoBehaviour {
	public GameObject GoldBox;
	public GameObject Brick;

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
		for(i=0; i<20; i++){
			for (j=0;j<10;j++){
				Vector3 CreatePosition = new Vector3(i-20,j,0);
				GameObject.Instantiate(Brick, CreatePosition, Quaternion.identity);
			}
		}
	}
}
