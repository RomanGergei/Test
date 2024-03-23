using System;
using UnityEngine;

public class AllyFactory : MonoBehaviour
{
    public GameObject AllyPrefab;
    [NonSerialized] public GameObject Ally;

    public void AllyCreate()
    {
        Ally = Instantiate(AllyPrefab);
    }
}
