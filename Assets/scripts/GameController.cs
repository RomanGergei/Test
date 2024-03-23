using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int Score = 0;
    public GameObject CanvasVictory; // канвас с всплывающим окошком победы
    public GameObject CanvasGameOver; // канвас с всплывающим окошком поражения
    public GameObject TextMassages; // текстовые сообщения, не несущие в себе счета или хэпэ, просто приколюхи
    public GameObject DirectionalLight;
    public GameObject Player;
    [SerializeField] private TextMessages _textMessages;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private AllyFactory _allyFactory;
    [SerializeField] private Health _health;

    public void StartGame()
    {
        _spawner.SpawnAlly();
        _textMessages.ScoreOnStart();
        _textMessages.HealthText();
        DirectionalLight.SetActive(true);
    }

    public void AllyCollected()
    {
        Score++;
        _spawner.AllyRandomLocation();
        _health.Resurrection();
        _textMessages.AddScoreText();
        _textMessages.TextMessagesOnCollisionAlly();
        _textMessages.HealthText();
    }
    public void Victory()
    {
        CanvasVictory.SetActive(true);
        DirectionalLight.SetActive(false);
        TextMassages.SetActive(false);
        Destroy(_allyFactory.Ally);
        Destroy(Player);
    }

    public void GameOver()
    {
        CanvasGameOver.SetActive(true);
        DirectionalLight.SetActive(false);
        TextMassages.SetActive(false);
        Destroy(_allyFactory.Ally);
        Destroy(Player);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ToFirstLevel()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void ToExitGame()
    {
        Debug.Log("ВЫХОД ИЗ ИГРЫ");
    }
}
