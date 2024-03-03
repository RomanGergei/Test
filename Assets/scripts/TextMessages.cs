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
                    textMessages.text = "������!";
                    break;
                case 2:
                    textMessages.text = "�������!";
                    break;
                case 3:
                    textMessages.text = "��� �������!";
                    break;
                case 4:
                    textMessages.text = "��� �������!";
                    break;
                case 5:
                    textMessages.text = "���������!";
                    break;

            }
        }

        if (col.gameObject.GetComponent<TreeScript>())
        {
            switch (PlayerDeath._touchingTree)
            {
                case 1:
                    textMessages.text = "������!";
                    break;
                case 2:
                    textMessages.text = "��� ������!";
                    break;
                case 3:
                    textMessages.text = "����� ������!";
                    break;
                case 4:
                    textMessages.text = "����� ������!";
                    break;
            }
        }
    }
}
