using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetName : MonoBehaviour {
	//Points p;
	public Text Username;
	// Use this for initialization
	void Start () {
		CharacterField ();
		//p.OnClick ();
	}
	

	public void CharacterField(){
		Username = GameObject.Find("Username").GetComponent<Text> ();
		Username.text = PlayerPrefs.GetString ("Username");
	}
}
