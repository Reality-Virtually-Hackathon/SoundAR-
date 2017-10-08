using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public Vector3 ChangeBy;
    Vector3 InitialPos;

    // Use this for initialization
    void Start()
    {
        InitialPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = InitialPos + Mathf.Sin( Time.time ) * ChangeBy;
    }
}
