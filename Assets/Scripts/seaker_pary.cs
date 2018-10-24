using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaker_pary : MonoBehaviour {

	// Use this for initialization
	public Rigidbody prayRb, seekerRb;
	public GameObject player, pray, seeker;
	public float seekSpeed, runSpeed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (gameObject.tag == "eatable") {
            prayRb.AddForce(Vector3.Normalize(pray.transform.position - player.transform.position) * runSpeed);
		}
		if (gameObject.tag == "Seek") {
			seekerRb.AddForce(Vector3.Normalize(player.transform.position - seeker.transform.position) * seekSpeed);
		}
	}

	void OnCollisionEnter(Collision other) {
		if (gameObject.tag == "eatable") {
			if (other.gameObject.name.Equals("Player")) {
				Destroy(gameObject);
			}
		}
        if (gameObject.tag == "Seek"){
            if (other.gameObject.name.Equals("Player"))
            {
                Destroy(player);
            }
        }
	}
}
