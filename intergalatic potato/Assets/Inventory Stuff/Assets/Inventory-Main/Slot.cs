using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventorymain inventory;
    private Pickup pickup;

    public GameObject[] parent;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventorymain>();
        pickup = GameObject.FindGameObjectWithTag("Part1").GetComponent<Pickup>();
    }
    public void Update()
    {

        if (!inventory.isFull)
        {
            // inventory.isFull[inventory.index] = false; 
            inventory.slotAvailable = 1;

        }

    }
    
    
}

    
   


