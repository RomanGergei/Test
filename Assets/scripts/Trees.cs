using UnityEngine;

public class Trees : MonoBehaviour
{
    [SerializeField] private Health _health;

    private void OnTriggerEnter(Collider other)
    {
        _health.TakeDamage();
    }
}
