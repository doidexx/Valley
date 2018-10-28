using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraS : MonoBehaviour {

	// Use this for initialization
	public Transform target, player;
	public Vector3 offset;
	void Start () {
		offset = new Vector3(0, -2, 5);
	}
    void Update(){
        transform.LookAt(player);
    }

    // Update is called once per frame
    void FixedUpdate () {
        transform.localPosition = Vector3.Lerp(transform.position, target.position, 0.5f);
	}
}
