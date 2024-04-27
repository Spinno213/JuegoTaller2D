using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    public int health;
    private PlayerController playerController;
    private SpriteRenderer playerRenderer;

    // Start is called before the first frame update
    void Start()
    {
        playerRenderer = GetComponent<SpriteRenderer>();
        playerController = FindAnyObjectByType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Dead();
    }

    private void Dead()
    {
        if (health <= 0)
        {
            playerController.playerSpeed = 0;
            playerRenderer.color = Color.grey;
        }
    }

    public void HealthModifier(int amount)
    {
        if (amount > 0)
        {
            health += amount;
        }
        else if (amount < 0)
        {
            health += amount;
        }
    }
}
