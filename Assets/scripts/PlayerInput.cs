using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Mover playerMover;
    private void FixedUpdate()
    {
        playerMover.Move();
    }
}
