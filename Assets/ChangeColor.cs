using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    /*
    I made a static variable for the buttons
    then I made a seperate class that I dragged into the buttons
    When clicking on the buttons, the variable will be set to a number that will be used for the next scene
    In the next scene I made a seperate script that changes the material to the number that is active
    The number will not bes resetted by loading a new scene because it is static
    */

    public static int Background = 1;

	public void SetColour(int Colour){
		Background = Colour;
	}
}