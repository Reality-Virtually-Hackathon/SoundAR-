using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class PModStartSize : AudioReader {
    
    protected override void _OnLevelChange( float f )
    {
        ParticleSystem.MainModule mm = GetComponent<ParticleSystem>().main;
        mm.startSize = f *.01f;
    }
}