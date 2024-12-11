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
    public GameObject text;
    public GameObject craftingUI;
    public Inventorymain inventory;
    public GameObject mimic;
    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventorymain>();
    }
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
    public void BtnClick()
    {
        Debug.Log("click");
        inventory.parts += 1;
        Instantiate(openedChest, this.transform);
        Destroy(this.gameObject);
        Destroy(InteractBtn);
    }
    public void activateMimic()
    {                           
        mimic.SetActive(true);
    }
}
