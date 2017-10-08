using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioWriter : MonoBehaviour {
    public System.Action<float> OnLevelChange;

    float currentLevel;
    public void OnAudioFilterRead( float[] data, int channels )
    {
        float fMax = 0f;
        foreach (float f in data)
            fMax = Mathf.Max( fMax, Mathf.Abs( f ) );
        currentLevel = fMax;
    }

    void Update()
    {
        OnLevelChange( currentLevel );
    }
}
