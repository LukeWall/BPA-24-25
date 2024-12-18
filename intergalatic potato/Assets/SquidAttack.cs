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

    void Start()
    {
    

        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.transform.position - attacker.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(Vector3.forward * angle);

        var distance = Vector2.Distance(attacker.transform.position, player.transform.position);// no need to perform this operation twice.
        if (distance < 40 && distance > 10)
        {
            direction = player.transform.position - attacker.transform.position;
            direction.Normalize();
           
            transform.rotation = Quaternion.Lerp(transform.rotation, player.transform.rotation, Time.deltaTime*10);
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            

        }
        else
        {
            
            if (nextFire <= 0 && distance<10)
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

