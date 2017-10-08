using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class PModStartSize : MonoBehaviour {
    ParticleSystem ps;

    [Range(.1f,1f)]
    public float StartSize = 1f;

	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update () {
        ParticleSystem.MainModule mm = ps.main;
        mm.startSize = StartSize;
	}
}