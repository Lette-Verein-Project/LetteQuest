using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Events;

public class Question : MonoBehaviour /*IPointerClickHandler*/{

	public GameObject Q;
	public GameObject A1;
	public GameObject A2;
	public GameObject A3;
	public GameObject A4;
	public GameObject B1;
	public GameObject bLvl;
	ArrayList list;
	object[] answers;
	int i = 0;
	int score = 0;


	void Start(){
		bLvl = GameObject.Find("MapButton");
		B1 = GameObject.Find ("Answer1");
		//B1.GetComponent<Button>().onClick.AddListener();// => { placeBuilding(obj.name); });

		Debug.Log(score);
		list = new ArrayList();

		list.Add (new Answer ("Wer?","er","sie","es","keiner"));
		list.Add (new Answer ("Was?","r","se","eks","kner"));
		list.Add (new Answer ("Wie?","e","s","k","i"));
		list.Add (new Answer ("Wo?","l","k","l","t"));
		list.Add (new Answer ("Wann?","r","n","m","x"));
		list.Add (new Answer ("","","","",""));

		//Answer[] s = new Answer[list.Count];
		//list.CopyTo (s, 3);
		answers = list.ToArray ();
		Answer a = (Answer) answers [i];

		Q = GameObject.Find ("question");
		Q.GetComponent<Text> ().text =a.question;

		A1 = GameObject.Find ("Atext1");
		A1.GetComponent<Text> ().text = a.answer1;

		A2 = GameObject.Find ("Atext2");
		A2.GetComponent<Text> ().text = a.answer2;

		A3 = GameObject.Find ("Atext3");
		A3.GetComponent<Text> ().text = a.answer3;

		A4= GameObject.Find ("Atext4");
		A4.GetComponent<Text> ().text = a.answer4;


		//text = GetComponent<Text> ();
		/*if (A1 == null) {
			Debug.Log("hallo");
		}*/
	}


	public void Click(){
		i++;
		if (i > 4) {


			Application.LoadLevel (2);

		}

		Answer a = (Answer) answers [i];
		Q = GameObject.Find ("question");
		Q.GetComponent<Text> ().text =a.question;		
		A1 = GameObject.Find ("Atext1");
		A1.GetComponent<Text> ().text = a.answer1;		
		A2 = GameObject.Find ("Atext2");
		A2.GetComponent<Text> ().text = a.answer2;		
		A3 = GameObject.Find ("Atext3");
		A3.GetComponent<Text> ().text = a.answer3;		
		A4= GameObject.Find ("Atext4");
		A4.GetComponent<Text> ().text = a.answer4;






		
	
	






	}

	/*public void onPointerClick(PointerEventData evtData){
	
	
	
		Debug.Log ("hadga");
	
	
	}*/






		


	// Update is called once per frame
	void Update () {


	}
}
