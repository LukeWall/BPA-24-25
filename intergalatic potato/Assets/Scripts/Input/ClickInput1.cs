using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickInput1 : MonoBehaviour
{
    private Camera _mainCamera;
    public 
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Awake()
    {
        _mainCamera = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(pos: (Vector3)Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;
        {

            Debug.Log(rayHit.collider.gameObject.name);
        }
    }
}