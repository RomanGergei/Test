using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text TimeDisplay;
    public GameObject Health;
    public GameObject Score;
    public GameObject Player;
    private int _time = 3;
    [SerializeField] private GameController _gameController;



    private void Awake()
    {
        Health.SetActive(false);
        Score.SetActive(false);
        Player.SetActive(false);
        _gameController.DirectionalLight.SetActive(false);
        StartCoroutine(TimeToStart());
    }

    public IEnumerator TimeToStart()
    {
        while (_time > 0) 
        {
            TimeDisplay.text = _time.ToString();
            yield return new WaitForSeconds(1f);
            _time--;
        }

        TimeDisplay.text = "œŒ√Õ¿À»!";
        yield return new WaitForSeconds(1f);
        TimeDisplay.gameObject.SetActive(false);
        Health.SetActive(true);
        Score.SetActive(true);
        Player.SetActive(true);
        _gameController.StartGame();
    }
}
