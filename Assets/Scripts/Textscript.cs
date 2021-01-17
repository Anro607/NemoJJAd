using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textscript : MonoBehaviour {

	Text realText;

	// Use this for initialization
	void Start () {
		realText = GetComponent<Text>();
		realText.text = "ㄴ..너가..";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
