using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

	public Rigidbody rb;
	public float viteza = 10f;
	public float jmpPow = 100f;
	public float lungRaza = 5f;
	private bool okJmp = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		okJmp = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tilt = Input.acceleration;
		tilt = Quaternion.Euler(90,0,0) * tilt;
		rb.AddForce(tilt * viteza);	

		RaycastHit hit;
		Ray raza = new Ray(transform.position, Vector3.down);

		if(Physics.Raycast(raza, out hit, lungRaza)){
			if(hit.collider.tag == "Sol"){
				okJmp = true;
			}
		} else{
			okJmp = false;
		}

		if(Input.GetMouseButtonDown(0) && okJmp){
			rb.AddForce(new Vector3(0, jmpPow, 0));
		}

	}

	void OnDrawGizmos(){
		Gizmos.color = Color.red;
		Gizmos.DrawLine(transform.position, transform.position + Vector3.down*lungRaza);
	}
}
