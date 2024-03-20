using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyFactory : MonoBehaviour
{
    public GameObject AllyPrefab;
    [NonSerialized] public GameObject _ally;

    public void AllyCreate()
    {
        _ally = Instantiate(AllyPrefab);
    }
}
