using UnityEngine;
using System.Collections;

public class HighlightOnMouseover : MonoBehaviour {

	private Color startcolor;

	void OnMouseEnter(){
		startcolor = GetComponent<Renderer>().material.color;
		GetComponent<Renderer>().material.color = Color.cyan;
	}

	void OnMouseExit(){
		GetComponent<Renderer>().material.color = startcolor;
	}
}
