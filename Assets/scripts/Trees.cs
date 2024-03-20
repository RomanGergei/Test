using UnityEngine;

public class Trees : MonoBehaviour
{
    [SerializeField] private Health _health;

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.GetComponent<Health>())
            _health.TakeDamage();
    }
}
