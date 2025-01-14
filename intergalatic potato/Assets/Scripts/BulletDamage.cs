using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int bulletDamage;
    private EnemyController enemyController;
    public Rigidbody2D rb;
    public float bulletForce = 40f;
    public bool fired = false;
    public void Start()
    {
        fired = true;
    }
    public void Update()
    {
        fired = true;
        if (fired == true)
        {

            transform.position += transform.forward * Time.deltaTime * bulletForce;
            GetComponent<Rigidbody2D>().velocity = transform.right * bulletForce;
        }

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("PlayerHit");
            Destroy(this.gameObject);
        }
    }

}

