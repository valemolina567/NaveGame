using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;

    public Slider healthBar; // para player o boss
    public bool isPlayer;    // para saber si gana o pierde

    void Start()
    {
        currentHealth = maxHealth;

        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = currentHealth;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (healthBar != null)
        {
            healthBar.value = currentHealth;
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GameManager gm = FindAnyObjectByType<GameManager>();

        if (gm != null)
        {
            if (isPlayer)
                gm.Lose();
            else
                gm.Win();
        }

        Destroy(gameObject);
    }
}