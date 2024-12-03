using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventorymain : MonoBehaviour
{
    
    public bool isFull = false;
    public GameObject slot;
    public int slotAvailable;
    public GameObject[] items;
    public int parts;
    public GameObject craftingUI;
    
    public void Start()
    {
        
    }
    public void Update()
    {
        if (parts == 4)
        {
            GameObject.Instantiate(craftingUI);
            parts = 0;
        }
        else craftingUI.SetActive(false);
    }
}
