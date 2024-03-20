using UnityEngine;
using UnityEngine.UI;

public class TextMessages : MonoBehaviour
{
    public Text ScoreText;
    public Text Text;
    public Text HealthLevel;
    [SerializeField] private Health _health;
    [SerializeField] private GameController _gameController;


    public void TextOnStart()
    {
        ScoreText.text = "����� �����!";
    }

    public void AddAllyText()
    {
        ScoreText.text = "������� �����: " + _gameController.Score;
    }

    public void HealthText()
    {
        HealthLevel.text = "���������: " + _health.CurrentHealth;
    }

    // ������ ����������� ������� �� ����� ���� ��������
    public void TextMessagesOnCollisionAlly()
    {
        switch (_gameController.Score)
        {
            case 0:
            case 1:
                Text.text = "������!";
                break;
            case 2:
                Text.text = "�������!";
                break;
            case 3:
                Text.text = "��� �������!";
                break;
            case 4:
                Text.text = "��� �������!";
                break;
            case 5:
                Text.text = "���������!";
                break;

        }
    }

    public void TextMessagesOnCollisionTrees()
    {
        switch (_health.CurrentHealth)
        {
            case 4:
                Text.text = "������!";
                break;
            case 3:
                Text.text = "��� ������!";
                break;
            case 2:
                Text.text = "����� ������!";
                break;
            case 1:
                Text.text = "����� ������!";
                break;
        }

    }
}
