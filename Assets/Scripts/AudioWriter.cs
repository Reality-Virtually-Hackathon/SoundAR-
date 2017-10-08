using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioWriter : MonoBehaviour {
    public System.Action<float> OnLevelChange;
    public System.Action<float> OnFreqChange;

    float currentLevel;
    float currentFreq;

    public void OnAudioFilterRead( float[] data, int channels )
    {
        float fMax = 0f;
        foreach (float f in data)
            fMax = Mathf.Max( fMax, Mathf.Abs( f ) );
        currentLevel = fMax;
    }

    void Update()
    {
        if (OnLevelChange != null)
            OnLevelChange( currentLevel );
        if (OnFreqChange != null)
        {
            int ixPeak = 0;
            float fMax = 0;
            float[] spectrum = new float[256];
            GetComponent<AudioSource>().GetSpectrumData( spectrum, 0, FFTWindow.Rectangular );

            for (int i = 1; i < spectrum.Length - 1; i++)
            {
                if (spectrum[i] > fMax)
                {
                    fMax = spectrum[i];
                    ixPeak = i;
                }
            }

            // 20 is a fudge factor...
            currentFreq = 20 * (float)ixPeak / (float)spectrum.Length;
            // Debug.Log( 20 * currentFreq );
            OnFreqChange( currentFreq );
        }
    }
}
