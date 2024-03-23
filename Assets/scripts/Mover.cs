using UnityEngine;


public class Mover : MonoBehaviour
{
    public float Speed = 4000f;
    public Rigidbody Rigidbody;
    [SerializeField] private PlayerInput _playerInput;

    private void FixedUpdate()
    {
        if (_playerInput.DirectionVector != null)
            Move();
    }

    public void Move()
    {
        Rigidbody.AddForce(_playerInput.DirectionVector * Speed);
    }

}





