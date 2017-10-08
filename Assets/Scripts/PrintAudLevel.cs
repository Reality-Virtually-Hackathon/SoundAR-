using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAudLevel : AudioReader {
    float lastVal = 0f;
    protected override void _OnLevelChange( float f )
    {
        lastVal = f;
    }

    // Update is called once per frame
    void Update () {
        Debug.Log( lastVal );
	}
}
