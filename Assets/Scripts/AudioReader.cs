using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class AudioReader : MonoBehaviour {
    public AudioWriter Writer;

    protected abstract void _OnLevelChange( float f );
    public void Start()
    {
        Writer.OnLevelChange += _OnLevelChange;
    }
}
