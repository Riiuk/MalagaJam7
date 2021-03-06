﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

	public float speed = 0.1f;
	public GameObject direction;
	public GameObject top;
	public GameObject bottom;
	public GameObject left;
	public GameObject right;


	// Update is called once per frame
	void Update () {
		Vector3 mov = new Vector3 (Input.GetAxisRaw ("HorizontalP2"), Input.GetAxisRaw ("VerticalP2"), 0);

		transform.position = Vector3.MoveTowards (transform.position, transform.position + mov, speed + Time.deltaTime);

		if (Input.GetAxisRaw ("HorizontalP2") < 0) {
			direction.transform.position = left.transform.position;
		}

		if (Input.GetAxisRaw ("HorizontalP2") > 0) {
			direction.transform.position = right.transform.position;
		}

		if (Input.GetAxisRaw ("VerticalP2") > 0) {
			direction.transform.position = top.transform.position;
		}

		if (Input.GetAxisRaw ("VerticalP2") < 0) {
			direction.transform.position = bottom.transform.position;
		}
	}
}
