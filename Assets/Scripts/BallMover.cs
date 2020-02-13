using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallMover : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float jumpForce = 15f;

    private Rigidbody2D selfRigidbody2d;
    private GameMaster gm;
    private Health health;
    private bool isGrounded = false;

    private void Start()
    {
        selfRigidbody2d = GetComponent<Rigidbody2D>();
        gm = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<GameMaster>();

    }

    public void Move(Vector2 input, bool jump)
    {
        input *= movementSpeed;
        input.y = selfRigidbody2d.velocity.y;

        selfRigidbody2d.velocity = input;

        if (jump && isGrounded)
            selfRigidbody2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            gm.points += 1;
        }
    }

    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.5f);
        isGrounded = colliders.Length > 1;
    }
}
