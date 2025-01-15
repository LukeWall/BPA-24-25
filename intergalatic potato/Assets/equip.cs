using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class equip : MonoBehaviour
{

    
    public GameObject weapon;
    public GameObject weaponIcon;
    public Transform weaponHolder;
    public GameObject player;
    Inventorymain inventory;
    public GameObject craftingUI;
    int unlocked = 0;

    // Start is called before the first frame update
    void Start()
    {
        weaponHolder = GameObject.FindGameObjectWithTag("PlayerHand").transform;
        player = GameObject.FindGameObjectWithTag("Player").gameObject;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventorymain>();
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").gameObject;
        
    }
    public void collect()
    {
        if (!inventory.isFull)
        {
           
            weaponIcon.SetActive(true);
            inventory.parts = 0;
            inventory.isFull = true;
            craftingUI.SetActive(false);
            Debug.Log("collected");
            SceneManager.LoadScene(4, LoadSceneMode.Single);
        }
    }
    public void equipWeapon()
    {
        Debug.Log("equip weapon");
        weaponHolder = GameObject.FindGameObjectWithTag("PlayerHand").transform;
        if (weaponHolder.childCount<1)
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
