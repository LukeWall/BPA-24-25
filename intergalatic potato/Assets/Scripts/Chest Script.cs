//using InventorySystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    
    public GameObject InteractBtn;
    public GameObject openedChest;
    public GameObject closedChest;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            InteractBtn.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            InteractBtn.SetActive(false);
        }
    }
}
