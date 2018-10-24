using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerS : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
        speed = 10f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.W)){
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
        }
		if (Input.GetKey(KeyCode.S)){
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * speed);
        }
        // Rotation
        float r = Input.GetAxis("Mouse X");
		transform.Rotate(new Vector3(0, r, 0), Space.World);
	}

	void OnColliderEnter(Collider other){
		if (other.gameObject.tag == "eatable") {

		}
	}
}
