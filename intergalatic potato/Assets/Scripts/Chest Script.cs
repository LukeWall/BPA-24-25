//using InventorySystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    int opened = 0;
    public GameObject InteractBtn;
    // Start is called before the first frame update
    void Start()
    {
        opened = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player") && opened != 1)
        {
            
            //InventoryController.instance.AddItem("Inventory", "Potato Tornado handle");
            //opened = 1;
        }
    }

}
