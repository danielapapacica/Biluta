using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Manager : MonoBehaviour {

	public static int scor;
	public int scorMaxim = 6;
	public Text textScor;
	public Text mesaj;

	public GameObject sfera;
	public float heightRst = -10f;

	public float timpRst = 2f;
	private bool startRst;
	private bool amRst = false;

	void Awake(){
		Time.timeScale = 1f;
		mesaj.gameObject.SetActive(false);
		startRst = false;
		amRst = false;
		scor = 0;

	}
	
	// Update is called once per frame
	void Update () {
		textScor.text = "Scor: " + scor;
		if(scor == scorMaxim){
			mesaj.text = "Ai castigat";
			mesaj.gameObject.SetActive(true);
		}

		if(startRst){
			StartCoroutine(Restart());
			startRst = false;
		}

		if(sfera.transform.position.y < heightRst){
			//Time.timeScale = 0f;
			mesaj.text = "Ai cazut :(";
			mesaj.gameObject.SetActive(true);
			if(!amRst){
				startRst = true;
				amRst = true;
			}
		}
	}

	IEnumerator Restart(){
		yield return new WaitForSeconds(timpRst);				 
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}
}
