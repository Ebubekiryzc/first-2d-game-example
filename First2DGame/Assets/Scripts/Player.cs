using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float jumpForce = 11f;

    private float _movementX;
    private bool _isGrounded;

    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private string WALK_ANIMATION = "Walk";
    private string JUMP_ANIMATION = "Jump";
    private string GROUND_TAG = "Ground";

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {

    }

    // Her frame i�in bir kere �a�r�l�r
    private void Update()
    {
        PlayerMoveKeyboard();
        PlayerJump();
        AnimatePlayer();
    }

    void PlayerMoveKeyboard()
    {
        _movementX = Input.GetAxisRaw("Horizontal");
        // Art� ise yukar� ya da sa�a, eksi ise a�a�� ya da sola

        transform.position += new Vector3(_movementX, 0, 0) * Time.deltaTime * moveForce;
    }

    void AnimatePlayer()
    {
        if (_movementX > 0)
        {
            _animator.SetBool(WALK_ANIMATION, true);
            _spriteRenderer.flipX = false;
        }
        else if (_movementX < 0)
        {
            _animator.SetBool(WALK_ANIMATION, true);
            _spriteRenderer.flipX = true;
        }
        else
        {
            _animator.SetBool(WALK_ANIMATION, false);
        }
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _isGrounded = false;
            _animator.SetTrigger(JUMP_ANIMATION);
            // ForceMode2D.Impulse: Anl�k bir etki olu�turmak i�in kullan�l�r.
            _rigidbody2D.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            _isGrounded = true;
        }
    }
}
