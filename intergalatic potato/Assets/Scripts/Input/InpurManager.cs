using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class InpurManager : MonoBehaviour
{
   
    public static Vector2 Movement;
    public bool click = false;
    private PlayerInput _playerInput;
    private InputAction _moveAction;
    private InputAction _clickAction;
    
    // Start is called before the first frame update
    private void Start()
    {
        
        _clickAction.Enable();
    }
    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();

        _moveAction = _playerInput.actions["Move"];
        _clickAction = _playerInput.actions["Click"];
    }

    private void Update()
    {
        Movement = _moveAction.ReadValue<Vector2>();
        
        click = false;
        if (_playerInput)
        {
            Debug.Log("click");
            
        }
    }

}
