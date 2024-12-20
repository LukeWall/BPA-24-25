using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Vector2 _movement;
    private Vector2 input;
    private InputAction _clickAction;
    private PlayerInput _playerInput;


    private Rigidbody2D _rb;
    public Animator animator;
    private Vector2 MostRecentlyMoved;

    public Transform Aim;
    bool isWalking = false;
    bool isAttacking = false;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _clickAction = _playerInput.actions["Click"];
    }
    private void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        

        animator.SetFloat("Horizontal", _movement.x);
        animator.SetFloat("Vertical", _movement.y);
        animator.SetFloat("Speed", _movement.sqrMagnitude);
        
    }
    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * _moveSpeed * Time.fixedDeltaTime);
        if (isWalking)
        {
            Vector3 vector3 = Vector3.left * input.x + Vector3.down * input.y;
            Aim.rotation = Quaternion.LookRotation(Vector3.forward, vector3);
        }
    }

    

}