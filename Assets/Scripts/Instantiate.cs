using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour {



	ColorBlock colorblock = ColorBlock.defaultColorBlock;
	ColorBlock colorblock2 = ColorBlock.defaultColorBlock;


	public GameObject QuizPrefab;
	public GameObject bBio;
	public GameObject bVerlauf;
	public GameObject bLvl;
	public GameObject bQuiz;
	public GameObject qR;
	public GameObject b1;
	public GameObject b2;
	public GameObject b3;
	public GameObject instance;
	public GameObject instance2;
	public GameObject map1;
	public GameObject map2;
	public GameObject map3;
	

	void Start (){


		bVerlauf = GameObject.Find("VerlaufButton");
		bLvl = GameObject.Find("MapButton");
		bQuiz = GameObject.Find("HomeButton");
		bBio = GameObject.Find("BiographieButton");
		qR = GameObject.Find("QR");
		b1 = GameObject.Find ("Button1");
		b2 = GameObject.Find ("Button2");
		b3 = GameObject.Find ("Button3");
		map1 = GameObject.Find("Karte");
		map2 = GameObject.Find("Karte2");
		map3 = GameObject.Find("Karte3");

		b1.SetActive (false);
		b2.SetActive (false);
		b3.SetActive (false);
		qR.SetActive (true);


		map1.SetActive (false);
		map2.SetActive (false);
		map3.SetActive (false);






		colorblock.normalColor = new Color (0,0, 0, 0.1f);
		colorblock.highlightedColor = new Color (0, 0, 0, 0.1f);

		colorblock2.normalColor = new Color (0, 0, 0, 1);
		colorblock2.highlightedColor = new Color (0, 0, 0, 1);



		bLvl.GetComponent<Button> ().colors = colorblock2;
		bVerlauf.GetComponent<Button> ().colors = colorblock2;
		bQuiz.GetComponent<Button> ().colors = colorblock2;
		bBio.GetComponent<Button> ().colors = colorblock2;

	}


	public void preFabVer () {


		b1.SetActive (false);
		b2.SetActive (false);
		b3.SetActive (false);
		qR.SetActive (true);


		map1.SetActive (false);
		map2.SetActive (false);
		map3.SetActive (false);

		Destroy (instance);
		Destroy (instance2);
		
		bVerlauf.GetComponent<Button> ().colors = colorblock;

		bLvl.GetComponent<Button> ().colors = colorblock2;
		bQuiz.GetComponent<Button> ().colors = colorblock2;
		bBio.GetComponent<Button> ().colors = colorblock2;



		instance = Instantiate (Resources.Load ("AB CANVAS", typeof(GameObject))) as GameObject;

	}

	public void preFabMap () {


		b1.SetActive (false);
		b2.SetActive (false);
		b3.SetActive (false);
		qR.SetActive (true);


		map1.SetActive (false);
		map2.SetActive (false);
		map3.SetActive (false);

		Destroy (instance);
		Destroy (instance2);
		bLvl.GetComponent<Button> ().colors = colorblock;

		bVerlauf.GetComponent<Button> ().colors = colorblock2;
		bQuiz.GetComponent<Button> ().colors = colorblock2;
		bBio.GetComponent<Button> ().colors = colorblock2;



		instance = Instantiate (Resources.Load ("AB CANVAS", typeof(GameObject))) as GameObject;


	}

	public void preFabHome () {

		Destroy (instance);
		Destroy (instance2);


		b1.SetActive (true);
		b2.SetActive (true);
		b3.SetActive (true);
		qR.SetActive (true);

		map1.SetActive (false);
		map2.SetActive (false);
		map3.SetActive (false);



		bQuiz.GetComponent<Button> ().colors = colorblock;


		bVerlauf.GetComponent<Button> ().colors = colorblock2;
		bLvl.GetComponent<Button> ().colors = colorblock2;
		bBio.GetComponent<Button> ().colors = colorblock2;

		//instance = Instantiate (Resources.Load ("AB CANVAS", typeof(GameObject))) as GameObject;


		//GameObject button1 = GameObject.Find ("Button1");
	}

	public void preFabBio () {


		b1.SetActive (false);
		b2.SetActive (false);
		b3.SetActive (false);
		qR.SetActive (false);


		map1.SetActive (false);
		map2.SetActive (false);
		map3.SetActive (false);

		Destroy (instance);
		Destroy (instance2);

		bBio.GetComponent<Button> ().colors = colorblock;

		bLvl.GetComponent<Button> ().colors = colorblock2;
		bVerlauf.GetComponent<Button> ().colors = colorblock2;
		bQuiz.GetComponent<Button> ().colors = colorblock2;

		instance = Instantiate (Resources.Load ("AC Canvas", typeof(GameObject))) as GameObject;



	}



	public void mapOne (){


		Destroy (instance);
		Destroy (instance2);

		map1.SetActive (true);
		map2.SetActive (false);
		map3.SetActive (false);



	}

	public void mapTwo (){
		
		
		Destroy (instance);
		Destroy (instance2);
		
		map1.SetActive (false);
		map2.SetActive (true);
		map3.SetActive (false);
		
		
		
	}


	public void mapThree (){
		
		
		Destroy (instance);
		Destroy (instance2);
		
		map1.SetActive (false);
		map2.SetActive (false);
		map3.SetActive (true);
		
		
		
	}

	// Update is called once per frame
	void Update () {



	}
}