using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Propiedades")]
    [SerializeField] private GameObject me;
    public float detectionRange;
    public float movementSpeed;

    [Space]
    [Header("Propiedades del jugador")]
    [SerializeField] private bool playerOnRange;
    private GameObject player;
    public float distance;
    private PlayerHealthSystem playerHealthSystem;
    public int damageIDeal;

    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectByType<PlayerController>().gameObject;
        playerHealthSystem = FindAnyObjectByType<PlayerHealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        ChasePlayer();
    }

    private void ChasePlayer()
    {
        if (playerOnRange)
        {
            Vector2 targetPos = new Vector2(player.transform.position.x, player.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPos,
                movementSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHealthSystem.HealthModifier(damageIDeal *= -1);
        }
    }
}
