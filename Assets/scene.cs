using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class scene : MonoBehaviour {


	// Use this for initialization
	void Start () {
		StartCoroutine (BallCreator());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator BallCreator() {
		while (true) {
			var r = new System.Random ();
			Debug.Log (r.Next (5));
			yield return new WaitForSeconds ((float)(r.Next (3)));
			createABall ();
		}
	}

	private void createABall() {
		var r = new System.Random ();
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		go.transform.SetPositionAndRotation (new Vector3 (r.Next (3), 4, r.Next (3)), Quaternion.identity);
		var c = go.AddComponent<Rigidbody> ();
		c.useGravity = true;
	}
}
