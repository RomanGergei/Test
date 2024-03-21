using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [NonSerialized] public Vector3 DirectionVector;
    private float _h;
    private float _v;

    public void Update()
    {
        _h = Input.GetAxis("Horizontal");
        _v = Input.GetAxis("Vertical");
        DirectionVector = new Vector3(_h, 0, _v);
    }



}