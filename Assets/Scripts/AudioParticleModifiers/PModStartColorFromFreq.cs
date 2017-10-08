using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( typeof( ParticleSystem ) )]
public class PModStartColorFromFreq : AudioReader
{
    public Gradient ColorValues;
    protected override void _OnFreqChange( float f )
    {
        ParticleSystem.MainModule mm = GetComponent<ParticleSystem>().main;
        mm.startColor = ColorValues.Evaluate( f );
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
