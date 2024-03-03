using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject friend;
    private float _randNum()
    {
        return Random.Range(-187, 187);
    }

    private void Awake()
    {
        NewFriend();
    }
    public void NewFriend()
    {
        Instantiate(friend, new Vector3(_randNum(), 20f, _randNum()), Quaternion.Euler(0, 0, 0));
    }

    public void Spawn()
    {
        if (AllyCollector.CollisionFriend == true) 
        {
            NewFriend();
            AllyCollector.CollisionFriend = false;
        }
    }
}