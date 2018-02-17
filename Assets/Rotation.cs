using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
	float a = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		a += 2 * Time.deltaTime;
		this.transform.rotation = Quaternion.Euler (a,a*3,a*2);
	}
}
