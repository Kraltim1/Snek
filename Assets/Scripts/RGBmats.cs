using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RGBmats : MonoBehaviour {

    // sinewave parameters
    private double freq;
    private double step;

    // POWAAAAAAH
    private float red;
    private float green;
    private float blue;

    private Material mymat;


    void Start () {
        freq = 3;    // adjust this to change the color cycle speed
                      // freq = rad / sec; with ~6.2 rad / cycle
        step = 0;     // time counter to step the sine waves
        mymat = GetComponent<Renderer>().material;
    }
    
    void Update () {
        // quick mafs

        step += freq * Time.deltaTime;

        // the value added to step is the radian offset for each wave,
        // to seperate them and generate a smooth RGB sequence.
        // Math.Sin gives a value between -1 and 1, but we need a value
        // from 0 to 1 for our rgb values, so we fix that here too
        red   = (float)((Math.Sin(step + 0) + 1) / 2);
        green = (float)((Math.Sin(step + 2) + 1) / 2);
        blue  = (float)((Math.Sin(step + 4) + 1) / 2);

        // apply the values to anything you want here :D
        
        mymat.SetColor("_EmissionColor", new Color(red, green, blue));
        mymat.EnableKeyword("_EMISSION");

    }
}
