using UnityEngine;
using UnityEngine.SceneManagement;

public class AllyCollector : MonoBehaviour
{
    [SerializeField] private GameController _gameController;

    // �������� � ���-�� �� �����, �� ��� ����� �� OnTrigger ���� ���������� ��������
    // is trigger, ��� ���� ������ ���������, ����� �������� ��������� ������ ���������� �������, 
    // ������ ���� ��� �� ����� ������ � ����� ��������. ��� ���� ����������)

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Ally>() && _gameController.Score != 6)
            _gameController.AllyCollected();

        if (col.gameObject.GetComponent<Ally>() && _gameController.Score == 6)
            _gameController.Victory();
    }
}
