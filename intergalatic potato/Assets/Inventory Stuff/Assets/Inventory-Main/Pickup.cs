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
            
                if (!inventory.isFull)
                {
                    //Item can be added to inventory

                    GameObject.Instantiate(itemIcon, inventory.slot.transform, false);
                    Destroy(gameObject);
                    inventory.isFull =  true;
                    
                   //break;
                }

               
                
            }
        }

    }



