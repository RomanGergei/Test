using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AllyCollector : MonoBehaviour
{
    public Text scoreText;
    public static int _score = 0;
    public static bool CollisionFriend = false;

    public void Win()
    {
        if (_score == 6)
        {
            SceneManager.LoadScene("BetweenLevels");
            _score = 0;
        }
    }
    public void AddScore()
    {
        scoreText.text = "явер: " + _score;
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<FriendsScript>() && _score !=6)
        {
            _score++;
            Destroy(col.gameObject);
            CollisionFriend = true;
        }
    }
}
