using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerS : MonoBehaviour {

	public float speed;
    public int eaten;
	// Use this for initialization
	void Start () {
        speed = 10f;
        eaten = 0;
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

    void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "eatable") {
            eaten++;
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            GetComponent<Rigidbody>().mass += 0.1f;
            speed += 0.5f;
		}
        if (other.gameObject.tag == "Seek"){
            if (transform.lossyScale.sqrMagnitude > other.gameObject.transform.lossyScale.sqrMagnitude){
                other.gameObject.SetActive(false);
                eaten++;
                transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
                GetComponent<Rigidbody>().mass += 0.1f;
                speed += 0.5f;
            } else {
                gameObject.SetActive(false);
            }
        }
	}
}
