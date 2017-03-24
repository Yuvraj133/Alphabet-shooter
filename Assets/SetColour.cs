using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColour : MonoBehaviour {
    /*
    I made a static variable for the buttons
    then I made a seperate class that I dragged into the buttons
    When clicking on the buttons, the variable will be set to a number that will be used for the next scene
    In the next scene I made a seperate script that changes the material to the number that is active
    The number will not bes resetted by loading a new scene because it is static
    */
    public Texture[] Colours = new Texture[3];

	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material.mainTexture = Colours [(ChangeColor.Background - 1)];
		transform.GetChild(0).GetComponent<Renderer>().material.mainTexture = Colours [(ChangeColor.Background - 1)];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
