using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class GetAudioSpectrum : MonoBehaviour
{
    public Gradient Colors;
    void Update()
    {
        float[] spectrum = new float[256];

        GetComponent<AudioSource>().GetSpectrumData( spectrum, 0, FFTWindow.Rectangular );

        int ixPeak = 0;
        float fMax = 0;
        for (int i = 1; i < spectrum.Length - 1; i++)
        {
            if (spectrum[i] > fMax)
            {
                fMax = spectrum[i];
                ixPeak = i;
            }
        }

        float fPeak = (float)ixPeak / (float)spectrum.Length;
        // ParticleSystem.MainModule mm = GetComponent<ParticleSystem>().main;
        // mm.startColor = Colors.Evaluate( fPeak );
        Debug.Log( fPeak );
    }
}
