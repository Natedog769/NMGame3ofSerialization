﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarButtons : ButtonBehaviour {

    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        buttonText.text = numberOfClicks.ToString();
        ButtonCountReset();
    }

   


}
