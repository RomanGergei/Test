using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public PlayerDeath PD;
    public AllyCollector AC;
    public Spawner Spawn;

    public void Update()
    {
        AC.AddScore();
        AC.Win();
        PD.GameOver();
        Spawn.Spawn();

    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ToFirstLevel()
    {
        SceneManager.LoadScene("FirstLevel");
    }
    public void ToSecondLevel()
    {
        SceneManager.LoadScene("SecondLevel");
    }
    public void ToExitGame()
    {
        Debug.Log("¬€’Œƒ »« »√–€");
    }
}
