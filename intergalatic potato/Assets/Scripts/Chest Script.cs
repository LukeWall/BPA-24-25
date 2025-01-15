//using InventorySystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    
    public GameObject InteractBtn;
    public GameObject openedLever;
    public GameObject closedLever;
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
        Instantiate(openedLever, this.transform, true);
        Destroy(this.gameObject);
        Destroy(InteractBtn);
    }
    public void activateMimic()
    {
        GameObject.Instantiate(openedLever, InteractBtn.transform);
        mimic.SetActive(true);
    }
}
