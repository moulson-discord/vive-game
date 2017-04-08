using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setcolour : MonoBehaviour {
    public Color myColor = new Color(0, 0, 255);
    public GameObject myObject;
	// Use this for initialization
	void Start () {
        myObject.GetComponent<Renderer>().material.color = myColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
