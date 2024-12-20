using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidAttack : MonoBehaviour
{
    public GameObject attacker;
    public GameObject player;
    public bool moving;
    public float nextFire;
    public float speed;
    public GameObject idle;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.transform.position - attacker.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        var distance = Vector2.Distance(attacker.transform.position, player.transform.position);// no need to perform this operation twice.
        if (distance < 40 && distance > 10)
        {
            direction = player.transform.position - attacker.transform.position;
            direction.Normalize();

            Vector3 vectorToTarget = player.transform.position - attacker.transform.position;
            float z = Mathf.Atan2((player.transform.position.y - attacker.transform.position.y), (player.transform.position.x - attacker.transform.position.x)) * Mathf.Rad2Deg - 90;
            Quaternion q = Quaternion.AngleAxis(z, attacker.transform.forward);
            attacker.transform.rotation = Quaternion.Slerp(attacker.transform.rotation, q, Time.deltaTime * 20);

            attacker.transform.position = Vector2.MoveTowards(attacker.transform.position, player.transform.position, speed * Time.deltaTime);
            

        }
        else
        {
            if (distance < 10)
            {
                Vector3 vectorToTarget = player.transform.position - attacker.transform.position;
                float z = Mathf.Atan2((player.transform.position.y - attacker.transform.position.y), (player.transform.position.x - attacker.transform.position.x)) * Mathf.Rad2Deg - 90;
                Quaternion q = Quaternion.AngleAxis(z, attacker.transform.forward);
                attacker.transform.rotation = Quaternion.Slerp(attacker.transform.rotation, q, Time.deltaTime * 20);
            }
            if (distance > 40)
            {
                attacker.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (nextFire <= 0 && distance<15)
            {

                Shoot();
                nextFire = 3;
            }
      
        }
        if (nextFire > 0)
        {
            nextFire = nextFire -= Time.deltaTime;
        }

    }
    public GameObject Bullet;

    public GameObject bulletPrefab;
    public Transform FirePoint;
    void Shoot()
    {

        nextFire = 1;
        Bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);


        Destroy(Bullet, 3f);

    }

}

