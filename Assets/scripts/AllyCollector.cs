using UnityEngine;
using UnityEngine.SceneManagement;

public class AllyCollector : MonoBehaviour
{
    [SerializeField] private GameController _gameController;

    // возможно € что-то не пон€л, но при смене на OnTrigger надо выставл€ть значение
    // is trigger, при этом физика пропадает, игрок начинает проходить сквозь триггерные объекты, 
    // данна€ тема чет не очень хороша в плане деревьев. тут надо объ€снени€)

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Ally>() && _gameController.Score != 6)
            _gameController.AllyCollected();

        if (col.gameObject.GetComponent<Ally>() && _gameController.Score == 6)
            _gameController.Victory();
    }
}
