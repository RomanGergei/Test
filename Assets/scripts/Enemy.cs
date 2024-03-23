using UnityEngine;

public class Enemy : MonoBehaviour

{
    [SerializeField] private Health _health;

    private void OnTriggerEnter(Collider other)
    {
        _health.Death();
    }
}
