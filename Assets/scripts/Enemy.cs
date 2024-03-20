using UnityEngine;

public class Enemy : MonoBehaviour

{
    [SerializeField] private Health _health;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Health>())
            _health.Death();
    }
}
