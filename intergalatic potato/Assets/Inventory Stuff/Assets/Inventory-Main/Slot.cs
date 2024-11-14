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
        for (int index = 0; index < inventory.isFull.Length; index++)
        {

            if (!inventory.isFull[index])
            {
                // inventory.isFull[inventory.index] = false; 
                inventory.slotAvailable = index;
                break;
            }
        }
    }

    public void dropItem1()
    {

        foreach (Transform child in parent[0].transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            Destroy(child.gameObject);
            inventory.isFull[0] = false;
        }

    }
    public void dropItem2()
    {

        foreach (Transform child in parent[1].transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            Destroy(child.gameObject);
            inventory.isFull[1] = false;
        }

    }
    public void dropItem3()
    {

        foreach (Transform child in parent[2].transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            Destroy(child.gameObject);
            inventory.isFull[2] = false;
        }

    }
    public void dropItem4()
    {

        foreach (Transform child in parent[3].transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            Destroy(child.gameObject);
            inventory.isFull[3] = false;
        }

    }
    public void dropItem5()
    {

        foreach (Transform child in parent[4].transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            Destroy(child.gameObject);
            inventory.isFull[4] = false;
        }

    }
    public void dropItem6()
    {

        foreach (Transform child in parent[5].transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            Destroy(child.gameObject);
            inventory.isFull[5] = false;
        }

    }
}

