using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecteaza : MonoBehaviour {

	public float rotatie = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, rotatie);
	}

	void OnTriggerEnter(Collider collider){
		
		if(collider.tag == "Sfera"){
			gameObject.SetActive(false);
			Manager.scor++;
		}
	}
}
