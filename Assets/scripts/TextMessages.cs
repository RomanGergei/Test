using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMessages : MonoBehaviour
{
    public Text textMessages;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<FriendsScript>())
        {
            switch (AllyCollector._score)
            {
                case 0:
                case 1:
                    textMessages.text = "онилюк!";
                    break;
                case 2:
                    textMessages.text = "лнкндеж!";
                    break;
                case 3:
                    textMessages.text = "рюй депфюрэ!";
                    break;
                case 4:
                    textMessages.text = "еые мелмнцн!";
                    break;
                case 5:
                    textMessages.text = "онякедмхи!";
                    break;

            }
        }

        if (col.gameObject.GetComponent<TreeScript>())
        {
            switch (PlayerDeath._touchingTree)
            {
                case 1:
                    textMessages.text = "депебн!";
                    break;
                case 2:
                    textMessages.text = "еые депебн!";
                    break;
                case 3:
                    textMessages.text = "ямнбю депебн!";
                    break;
                case 4:
                    textMessages.text = "ноърэ депебн!";
                    break;
            }
        }
    }
}
