using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEditor.Animations;
using UnityEngine.Animations;
/*
public class SwordSwingScript : MonoBehaviour
{
    public float damage = 1;
    BoxCollider2D swordcol;
    public GameObject Sword;
    private Animation anim;
    public EnemyHealth enemyHealth;

    public Transform attackLocation;
    public float attackRange;
    public LayerMask enemies;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Attack()
    {
        Debug.Log("attacking");
        anim.Play("attack");

        Collider2D[] damage = Physics2D.OverlapCircleAll(attackLocation.position, attackRange, enemies);

        for (int i = 0; i < damage.Length; i++)
        {
            Destroy(damage[i].gameObject);
        }



    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackLocation.position, attackRange);
    }



}*/