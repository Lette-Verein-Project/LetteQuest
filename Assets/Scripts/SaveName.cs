using UnityEngine;
using System.Collections;
using UnityEngine.UI;




public class SaveName : MonoBehaviour {
	

	public Text Username;

	void Start(){
		Username = GameObject.Find("Username").GetComponent<Text> ();
	}

	public void CharacterField(string inputFieldString){
		Username.text = inputFieldString;
		PlayerPrefs.SetString ("Username", inputFieldString);
		//DontDestroyOnLoad (CharText.gameObject);
	}

}