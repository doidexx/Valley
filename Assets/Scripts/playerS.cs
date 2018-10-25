using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerS : MonoBehaviour {

	public float speed, cooldown, sprinting;
    public bool sprint, coolingdown;
    public int eaten;
	// Use this for initialization
	void Start () {
        speed = 10f;
        eaten = 0;
        sprinting = 0;
        cooldown = 0;
        sprint = false;
        coolingdown = false;
	}
    void Update (){
        //Winning condition
        if (eaten == 14) {

        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.S)){
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * speed);
        }
        if (sprint){
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.W)){
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
        }
        // Rotation
        float r = Input.GetAxis("Mouse X");
		transform.Rotate(new Vector3(0, r, 0), Space.World);

        //sprinting
        if (Input.GetKey(KeyCode.Q) && !sprint && !coolingdown){
            sprint = true;
        }
        if (sprint){
            sprinting += Time.deltaTime;
        }
        if (sprinting > 0.05f){
            sprint = false;
            sprinting = 0;
            coolingdown = true;
        }
        if (coolingdown){
            cooldown += Time.deltaTime;
        }
        if (cooldown > 5f){
            coolingdown = false;
            cooldown = 0;
        }
	}

    void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "eatable") {
            eaten++;
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            GetComponent<Rigidbody>().mass += 0.1f;
            speed += 0.5f;
            other.gameObject.SetActive(false);
		}
        if (other.gameObject.tag == "Seek"){
            if (transform.lossyScale.sqrMagnitude > other.gameObject.transform.lossyScale.sqrMagnitude){
                other.gameObject.SetActive(false);
                eaten++;
                transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
                GetComponent<Rigidbody>().mass += 0.1f;
                speed += 1.2f;
            } else {
                gameObject.SetActive(false);
            }
        }
	}
}
