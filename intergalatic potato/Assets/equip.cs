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
            Debug.Log("collected");
            weaponIcon.SetActive(true);
            Destroy(gameObject);
            inventory.isFull = true;
            craftingUI.SetActive(false);
            SceneManager.LoadScene(4, LoadSceneMode.Single);
        }
    }
    public void equipWeapon()
    {
        Debug.Log("equip weapon");
       
        if (weaponHolder.transform.childCount <2)
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
