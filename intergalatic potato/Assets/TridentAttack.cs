using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridentAttack : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private float meleeSpeed;
    [SerializeField] private float Damage;
    public Input Input;
   
    float timeUntilMelee;
    bool isAttacking;
    private void Update()
    {
        if(timeUntilMelee <= 0f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(isAttacking == true)
                {
                    anim.SetTrigger("TridentAttack");
                    isAttacking = false;
                }
                Debug.Log("attack");
                
                timeUntilMelee = meleeSpeed;
            }
        }
        else
        {
            timeUntilMelee -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Enemy hit");
        }
    }

}
