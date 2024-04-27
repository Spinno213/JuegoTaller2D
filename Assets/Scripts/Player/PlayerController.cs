using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("[Movimiento]")]
    [SerializeField] private float playerHorizontalMovementInput;
    [SerializeField] private float playerVerticalMovementInput;
    public float playerMoveDirection = 1f;
    public float playerSpeed;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        playerHorizontalMovementInput = Input.GetAxisRaw("Horizontal");
        playerVerticalMovementInput = Input.GetAxisRaw("Vertical");
        Vector2 movementVector = new Vector2(playerHorizontalMovementInput * playerSpeed, playerVerticalMovementInput * playerSpeed);
        rb2d.velocity = movementVector;
    }
}
