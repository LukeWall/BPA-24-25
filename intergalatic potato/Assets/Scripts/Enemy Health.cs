/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    GameObject weapon1;
    public GameObject player;
    public Collider collider;
    public SwordSwingScript swing;
    [SerializeField] private float maxHealth = 3f;

    private float currentHealth;

    private void Start()
    {
        swing = player.GetComponentInChildren<SwordSwingScript>();
        collider = player.GetComponentInChildren<Collider>();
        currentHealth = maxHealth;
    }
    public void OnTriggerEnter(Collider weapon)
    {
        if(weapon.tag == "weapon")
        {
            currentHealth -= swing.damage;
        }
        if(currentHealth<=0)
        {
            Destroy(gameObject);
        }
    }

    public void Die()
    {
        Destroy(gameObject); 
    }
}
*/