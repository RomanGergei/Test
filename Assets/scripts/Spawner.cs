using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private AllyFactory _allyFactory;
    public int MapSizeXMin = -303;
    public int MapSizeXMax = 303;
    public int MapSizeZMin = -185;
    public int MapSizeZMax = 185;


    public void SpawnAlly()
    {
        _allyFactory.AllyCreate();
        AllyRandomLocation();
    }

    public void AllyRandomLocation()
    {
        _allyFactory._ally.transform.position = new Vector3(RandomX(), 20f, RandomZ());
    }

    public float RandomX()
    {
        return UnityEngine.Random.Range(MapSizeXMin, MapSizeXMax);
    }
    public float RandomZ()
    {
        return UnityEngine.Random.Range(MapSizeZMin, MapSizeZMax);
    }


}