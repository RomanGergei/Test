using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int MapSizeXMin = -303;
    public int MapSizeXMax = 303;
    public int MapSizeZMin = -185;
    public int MapSizeZMax = 185;
    [SerializeField] private AllyFactory _allyFactory;



    public void SpawnAlly()
    {
        _allyFactory.AllyCreate();
        AllyRandomLocation();
    }

    public void AllyRandomLocation()
    {
        _allyFactory.Ally.transform.position = new Vector3(RandomX(), 20f, RandomZ());
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