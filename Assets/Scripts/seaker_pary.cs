using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaker_pary : MonoBehaviour {

	// Use this for initialization
	public Rigidbody prayRb, seekerRb;
	public GameObject player, pray, seeker;
	public Material actual;
	public float seekSpeed, runSpeed;

	void Start () {
		actual = GetComponent<MeshRenderer>().material;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (gameObject.tag == "eatable") {
            prayRb.AddForce(Vector3.Normalize(pray.transform.position - player.transform.position) * runSpeed);
		}
		if (gameObject.tag == "Seek") {
            if (player.transform.localScale.sqrMagnitude < transform.localScale.sqrMagnitude){
				seekerRb.AddForce(Vector3.Normalize(player.transform.position - seeker.transform.position) * seekSpeed);
			} else {
                seekerRb.AddForce(Vector3.Normalize(seeker.transform.position - player.transform.position) * seekSpeed);
				actual.color = Color.green;
			}
		}
	}
}
