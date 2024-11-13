using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventorymain inventory;
    public GameObject itemIcon;
    public int craft = 1;
    public GameObject crafted;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventorymain>();
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0;i<inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //Item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemIcon, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    inventory.isFull[i] = true;
                }
                break;
            }
        }
       
    }
    

}
