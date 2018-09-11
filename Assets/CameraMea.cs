using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMea : MonoBehaviour {

	public Transform tinta;
	Vector3 dist;

	// Use this for initialization
	void Start () {
		dist = transform.position - tinta.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = tinta.position + dist;
	}
}
