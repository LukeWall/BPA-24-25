using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class equip : MonoBehaviour
{

    
    public GameObject weapon;
    public GameObject weaponIcon;
    
    public GameObject player;
    Inventorymain inventory;
    public GameObject craftingUI;

    // Start is called before the first frame update
    void Start()
    {
       
        inventory = player.GetComponent<Inventorymain>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void collect()
    {
        if (!inventory.isFull)
        {
            GameObject.Instantiate(weaponIcon, inventory.slot.transform, false);
            Destroy(gameObject);
            inventory.isFull = true;
            GameObject.Destroy(craftingUI);
        }
    }
    public void equipWeapon()
    {
        Debug.Log("equip weapon");
        Transform weaponHolder = player.transform.GetChild(0).transform;
        if (weaponHolder.transform.childCount <1)
        {
            GameObject.Instantiate(weapon, weaponHolder,false);
        }
        else
        {
            GameObject.Destroy(weaponHolder.transform.GetChild(0).gameObject);
            GameObject.Instantiate(weapon, weaponHolder, false);
        }
        
    }

}
