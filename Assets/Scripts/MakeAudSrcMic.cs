using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAudSrcMic : MonoBehaviour
{
    private void Start()
    {
        foreach (string s in Microphone.devices)
            Debug.Log( s );
        AudioSource aud = GetComponent<AudioSource>();
        aud.clip = Microphone.Start( Microphone.devices[0], true, 10, 48000 );
        aud.loop = true;
        while (!(Microphone.GetPosition( null ) > 0)) { }
        aud.Play();
    }
}
