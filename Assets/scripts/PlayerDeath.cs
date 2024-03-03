using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerDeath : MonoBehaviour
{
    public static int _touchingTree = 0;
    public static bool _isDead = false;

    public void GameOver()
    {
        if (_isDead == true)
        {
            SceneManager.LoadScene("GameOver");
            AllyCollector._score = 0;
            _isDead = false;
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<FriendsScript>())
            _touchingTree = 0;

        if (col.gameObject.GetComponent<TreeScript>())
        {
            _touchingTree++;
            if (_touchingTree == 5)
            {
                _isDead = true;
            }
        }

        if (col.gameObject.GetComponent<EnemyScript>())
            _isDead = true;
    }



}


