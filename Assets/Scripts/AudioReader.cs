using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioReader : MonoBehaviour {
    public AudioWriter Writer;

    protected virtual void _OnLevelChange( float f ) { }
    protected virtual void _OnFreqChange( float f ) { }

    public void Start()
    {
        if (Writer == null)
            Writer = GetComponent<AudioWriter>();
        Writer.OnLevelChange += _OnLevelChange;
        Writer.OnFreqChange += _OnFreqChange;
    }
}
