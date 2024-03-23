using UnityEngine;

public class Ally : MonoBehaviour
{
    [SerializeField] private GameController _gameController;

    private void OnTriggerEnter(Collider other)
    {
        if (_gameController.Score != 6)
            _gameController.AllyCollected();

        if (_gameController.Score == 6)
            _gameController.Victory();
    }   
}

