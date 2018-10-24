using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraS : MonoBehaviour {

	// Use this for initialization
	public Transform target;
	public Vector3 offset;
	void Start () {
		offset = new Vector3(0, -2, 5);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.LookAt(target);
		//transform.localPosition = Vector3.Lerp(transform.position, target.position - offset, 0.125f);
	}
}
