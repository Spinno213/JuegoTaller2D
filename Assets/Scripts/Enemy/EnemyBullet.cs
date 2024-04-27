using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private int damage;
    private Rigidbody2D rb2d;
    private PlayerHealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        healthSystem = FindAnyObjectByType<PlayerHealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            healthSystem.HealthModifier(damage * -1);
            Destroy(gameObject);
        }
    }
}
