﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScript : MonoBehaviour {

	// Use this for initialization
	public GameObject player, seeker, pray;
	public int seekerN, prayN;
	void Start () {
		for (int i = 0; i < seekerN; i++) {
			Instantiate(seeker, new Vector3(Random.Range(-200,200), 20, Random.Range(-200, 200)), Quaternion.identity);
            Instantiate(pray, new Vector3(Random.Range(-200, 200), 20, Random.Range(-200, 200)), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	}
}
