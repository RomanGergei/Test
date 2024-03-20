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
        ScoreText.text = "ксрюи рхонб!";
    }

    public void AddAllyText()
    {
        ScoreText.text = "гюксрюк рхонб: " + _gameController.Score;
    }

    public void HealthText()
    {
        HealthLevel.text = "ущощьевйю: " + _health.CurrentHealth;
    }

    // ПЮГМШЕ БЯОКШБЮЧЫХЕ МЮДОХЯХ МЮ ЙЮЙХЕ КХАН ЙНККХГХХ
    public void TextMessagesOnCollisionAlly()
    {
        switch (_gameController.Score)
        {
            case 0:
            case 1:
                Text.text = "онилюк!";
                break;
            case 2:
                Text.text = "лнкндеж!";
                break;
            case 3:
                Text.text = "рюй депфюрэ!";
                break;
            case 4:
                Text.text = "еые мелмнцн!";
                break;
            case 5:
                Text.text = "онякедмхи!";
                break;

        }
    }

    public void TextMessagesOnCollisionTrees()
    {
        switch (_health.CurrentHealth)
        {
            case 4:
                Text.text = "депебн!";
                break;
            case 3:
                Text.text = "еые депебн!";
                break;
            case 2:
                Text.text = "ямнбю депебн!";
                break;
            case 1:
                Text.text = "ноърэ депебн!";
                break;
        }

    }
}
