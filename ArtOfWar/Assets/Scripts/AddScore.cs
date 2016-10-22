using UnityEngine;
using System.Collections;

public class AddScore : MonoBehaviour {
	private GUIText mGUIText;
	private GUIText mGUIText2;

	void Start() {
		mGUIText = gameObject.GetComponent<GUIText> ();
		mGUIText2 = gameObject.GetComponent<GUIText> ();
	}

	public void addScore(){
		int score = int.Parse(mGUIText.text);
		score++;
		mGUIText.text = score.ToString();
	}
}
