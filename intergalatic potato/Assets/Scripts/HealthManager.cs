using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{

    [HideInInspector] public float Health = 100;
    public int MaxHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HurtPlayer(float damaged)
    {
        Health = Health -= damaged;
        Debug.Log(Health);
    }
}
