using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public static UserInput instance;

     public Controls controls;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = null;
        }
        controls = new Controls();
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
