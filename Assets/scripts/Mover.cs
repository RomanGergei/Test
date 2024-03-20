using UnityEngine;


public class Mover : MonoBehaviour
{
    public float Speed = 5000f;
    public Rigidbody _rb;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        float h = Input.GetAxis("Horizontal") * Speed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * Speed * Time.fixedDeltaTime;
        _rb.velocity = transform.TransformDirection(new Vector3(h, _rb.velocity.y, v));

    }

}





