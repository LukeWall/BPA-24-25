using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int bulletDamage;
    private EnemyController enemyController;

    public void Start()
    {
        enemyController = GetComponent<EnemyController>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().damagePlayer(bulletDamage);
            Destroy(gameObject);
        }
    }
  
}

