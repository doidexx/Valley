using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaker_pary : MonoBehaviour {

	// Use this for initialization
	public Rigidbody prayRb, seekerRb;
	public GameObject player, pray, seeker, trigger;
	public Material actual;
	public float seekSpeed, runSpeed;

	private Vector3 direction, direction1;

	void Start () {
		actual = GetComponent<MeshRenderer>().material;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (player.transform.localScale.sqrMagnitude > transform.localScale.sqrMagnitude){
            actual.color = Color.green;
		}
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player){
        	if (gameObject.tag == "eatable"){	
				direction = Vector3.Normalize(pray.transform.position - player.transform.position);
           		prayRb.AddForce(direction * runSpeed, ForceMode.VelocityChange);
        	}
            if (gameObject.tag == "Seek"){
                if (player.transform.localScale.sqrMagnitude < transform.localScale.sqrMagnitude){
                    seekerRb.AddForce(Vector3.Normalize(player.transform.position - seeker.transform.position) * seekSpeed, ForceMode.VelocityChange);
                } else {
                    seekerRb.AddForce(Vector3.Normalize(seeker.transform.position - player.transform.position) * runSpeed, ForceMode.VelocityChange);
                }
            }
		}
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            if (gameObject.tag == "eatable")
            {
                direction = Vector3.Normalize(pray.transform.position - player.transform.position);
                prayRb.AddForce(direction * runSpeed * 30);
            }
            if (gameObject.tag == "Seek")
            {
                if (player.transform.localScale.sqrMagnitude < transform.localScale.sqrMagnitude)
                {
                    seekerRb.AddForce(Vector3.Normalize(player.transform.position - seeker.transform.position) * seekSpeed * 30);
                }
                else
                {
                    seekerRb.AddForce(Vector3.Normalize(seeker.transform.position - player.transform.position) * runSpeed * 30);
                }
            }
        }
    }
}
