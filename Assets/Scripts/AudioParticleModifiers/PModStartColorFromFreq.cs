using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( typeof( ParticleSystem ) )]
public class PModStartColorFromFreq : AudioReader
{
    float fTarget, fDiff = 0.05f, fLast;

    public Gradient ColorValues;
    protected override void _OnFreqChange( float f )
    {
        //Debug.Log( f );
        fTarget = f;

        Color c = ColorValues.Evaluate( f );
        ParticleSystem.Particle[] p = new ParticleSystem.Particle[0];
        int nParticles = GetComponent<ParticleSystem>().GetParticles( p );
        for (int i = 0; i < nParticles; i++)
            p[i].remainingLifetime= 0.5f;
        // GetComponent<ParticleSystem>().SetParticles( p, nParticles );
        ParticleSystem.MainModule mm = GetComponent<ParticleSystem>().main;
        mm.startColor = ColorValues.Evaluate( f );
    }
	
	// Update is called once per frame
	void Update ()
    {
        //float fRemain = fTarget - fLast;
        //if (Mathf.Abs( fRemain ) > fDiff)
        //    fLast += fDiff * fRemain;
        //Debug.Log( fTarget + ", " + fLast );
    }
}
