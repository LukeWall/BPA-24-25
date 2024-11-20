using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Slot slot;
    
    private Inventorymain inventory;
    public GameObject itemIcon;
    
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventorymain>();
        //slot = GameObject.FindGameObjectWithTag("slot").GetComponent<Slot>();
    }
    private void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //Item can be added to inventory

                    Instantiate(itemIcon, inventory.slots[inventory.slotAvailable].transform, false);
                    Destroy(gameObject);
                    inventory.isFull[inventory.slotAvailable] = true;
                    
                   //break;
                }
                
                
            }
        }

    }


}
