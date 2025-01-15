//using InventorySystem;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class LeverHooray : MonoBehaviour
{

    public GameObject InteractBtn1;
    public GameObject openedLever1;
    public GameObject closedLever1;
    public GameObject InteractBtn2;
    public GameObject openedLever2;
    public GameObject closedLever2;
    public GameObject InteractBtn3;
    public GameObject openedLever3;
    public GameObject closedLever3;
    public GameObject InteractBtn4;
    public GameObject openedLever4;
    public GameObject closedLever4;
    public GameObject text;
    int count1 = 0;
    public GameObject craftingUI;
    public Inventorymain inventory;
    public GameObject mimic;

    public string count;

    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventorymain>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            InteractBtn1.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            InteractBtn1.SetActive(false);
        }
    }
    public void BtnClick1()
    {
        Debug.Log("click");
        inventory.parts += 1;
        Instantiate(openedLever1, openedLever1.transform, true);
        InteractBtn1.SetActive(false);
        closedLever1.SetActive(false);
        openedLever1.SetActive(true);
        count += "Hello";
        count1 = count.Length;
        if (count == "HelloWorldIPotato")
        {
            //Use to destroy pedastols
            Destroy(GameObject.FindGameObjectWithTag("wall"));
        }
        else if (count1 == 16 && count != "HelloWorldIPotato")
        {
            count = "";
            GameObject.FindGameObjectWithTag("interactbtns").SetActive(true);
        }
    }
    public void BtnClick2()
    {
        Debug.Log("click");
        inventory.parts += 1;
        Instantiate(openedLever2, openedLever2.transform, true);
        InteractBtn2.SetActive(false);
        closedLever2.SetActive(false);
        openedLever2.SetActive(true);
        count += "I";
        count1 = count.Length;
        if (count == "HelloWorldIPotato")
        {
            //Use to destroy pedastols
            Destroy(GameObject.FindGameObjectWithTag("wall"));
        }
        else if (count1 == 16 && count != "HelloWorldIPotato")
        {
            count = "";
            GameObject.FindGameObjectWithTag("interactbtns").SetActive(true);
        }
    }
    public void BtnClick3()
    {
        Debug.Log("click");
        inventory.parts += 1;
        Instantiate(openedLever3, openedLever3.transform, true);
        InteractBtn3.SetActive(false);
        closedLever3.SetActive(false);
        openedLever3.SetActive(true);
        count += "World";
        int count1 = count.Length;
        if (count == "HelloWorldIPotato")
        {
            //Use to destroy pedastols
            Destroy(GameObject.FindGameObjectWithTag("wall"));
        }
        else if (count1 == 16 && count != "HelloWorldIPotato")
        {
            count = "";
            GameObject.FindGameObjectWithTag("interactbtns").SetActive(true);
        }
    }
    public void BtnClick4()
    {
        
        Debug.Log("click");
        inventory.parts += 1;
        Instantiate(openedLever4, openedLever4.transform, true);
        InteractBtn4.SetActive(false);
        closedLever4.SetActive(false);
        openedLever4.SetActive(true);
        count += "Potato";
        count1 = count.Length;
        if (count == "HelloWorldIPotato")
        {
            //Use to destroy pedastols
            Destroy(GameObject.FindGameObjectWithTag("wall"));
        }
        

    }
    public void Update()
    {
        if (count != "HelloWorldIPotato"&&inventory.parts==4)
        {
            count = "";
            closedLever1.SetActive(true);
            openedLever1.SetActive(false);
            closedLever2.SetActive(true);
            openedLever2.SetActive(false);
            closedLever3.SetActive(true);
            openedLever3.SetActive(false);
            closedLever4.SetActive(true);
            openedLever4.SetActive(false);
            InteractBtn1.SetActive(true);
            InteractBtn2.SetActive(true);
            InteractBtn3.SetActive(true);
            InteractBtn4.SetActive(true);
            inventory.parts = 0;
        }

    }
}
