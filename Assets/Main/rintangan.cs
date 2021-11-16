using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rintangan : MonoBehaviour {

	public float delta = 1.5f;
	public float speed = 2.0f;
	public Vector3 startpos;

	// Use this for initialization
	void Start () {
		startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = startpos;
		v.y += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;
	}
}
