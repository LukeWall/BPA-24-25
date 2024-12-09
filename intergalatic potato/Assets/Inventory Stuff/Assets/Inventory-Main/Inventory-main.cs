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
    public GameObject spawn;
    
    public GameObject[] spawns;
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
        
    }
    public void Spawn(int spawnTracker)
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("MainCamera").transform.position;
    }
}
