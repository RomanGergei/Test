using UnityEngine;

public class Health : MonoBehaviour
{   
    public float StartHealth = 5f;
    public float CurrentHealth = 5f;
    [SerializeField] private GameController _gameController;
    [SerializeField] private TextMessages _textMessages;

    public void TakeDamage() 
    {
        CurrentHealth--;
        _textMessages.TextMessagesOnCollisionTrees();
        _textMessages.HealthText();

        if (CurrentHealth == 0)
            Death();
    }

    public void Resurrection()
    {
        CurrentHealth = StartHealth;
    }

    public void Death()
    {
        _gameController.GameOver();
    }

}


