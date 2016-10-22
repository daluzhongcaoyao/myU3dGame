using UnityEngine;
using System.Collections;

public class AddScore : MonoBehaviour {
	private GUIText mGUIText;

	void Start() {
		mGUIText = gameObject.GetComponent<GUIText> ();


	}

	public void addScore(){
		int score = int.Parse(mGUIText.text);
		score++;
		mGUIText.text = score.ToString();
	}
}
