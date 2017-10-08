using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class PModNoiseStrengthFromFreq : AudioReader {
    public float Initial, Offset;
    protected override void _OnLevelChange( float f )
    {
        ParticleSystem.NoiseModule nm = GetComponent<ParticleSystem>().noise;
        nm.strengthMultiplier = (1 + 50 * f)/100f;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
