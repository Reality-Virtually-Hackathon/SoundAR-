using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class PModSizeOverLifeCurve : MonoBehaviour {
    ParticleSystem.SizeOverLifetimeModule solm;
    ParticleSystem.MinMaxCurve initialSizeOverLifeCurve;
    ParticleSystem.MinMaxCurve initialStartSize;

    [Range( 0, 1 )]
    public float AffectStrength = 0f;

	// Use this for initialization
	void Start ()
    {
        initialStartSize = GetComponent<ParticleSystem>().main.startSize;
        solm = GetComponent<ParticleSystem>().sizeOverLifetime;
        initialSizeOverLifeCurve = solm.size;
        solm.enabled = false;
        solm.size = initialStartSize;
    }
	
	// Update is called once per frame
	void Update ()
    {
        ParticleSystem.Particle[] particles = new ParticleSystem.Particle[GetComponent<ParticleSystem>().particleCount];
        int nParticles = GetComponent<ParticleSystem>().GetParticles( particles );
        for (int p = 0; p < nParticles; p++)
        {
            particles[p].size = Mathf.Lerp( initialStartSize.constant, initialSizeOverLifeCurve.Evaluate( particles[p].remainingLifetime ), AffectStrength );
        }
        GetComponent<ParticleSystem>().SetParticles( particles, nParticles );
	}
}
