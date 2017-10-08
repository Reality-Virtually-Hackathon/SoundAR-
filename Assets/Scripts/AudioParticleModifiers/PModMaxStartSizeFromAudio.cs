using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class PModMaxStartSizeFromAudio : AudioReader
{
    public float Amount = 1f;
    protected override void _OnLevelChange( float f )
    {
        ParticleSystem.SizeOverLifetimeModule solm = GetComponent<ParticleSystem>().sizeOverLifetime;
        solm.sizeMultiplier = 1 + Amount * f;
    }
}
