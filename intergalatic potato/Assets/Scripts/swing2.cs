/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing2 : MonoBehaviour
{
    private Transform target;
    public float range;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    public GameObject bulletPrefab;
    public Transform firePoint;


    EnemyHealth enemyStats;

    public float speed;
    public int damage;
    public GameObject impactEffect;

    public EnemyHealth enemyHealth;
    void Start()
    {

    }

    void UpdateTarget()
    {



        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject neareastEnemy = null;
        foreach (GameObject Enemy in enemies)
        {
            float distanceToEnemy = Vector2.Distance(transform.position, Enemy.transform.position);
            if (distanceToEnemy <= shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                neareastEnemy = Enemy;
            }
            if (neareastEnemy != null && shortestDistance <= range)
            {
                target = neareastEnemy.transform;
            }
            else
            {
                target = null;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;


        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }


        transform.Translate(dir.normalized * distanceThisFrame, Space.World);

        void HitTarget()
        {
            Debug.Log("WE HIT SOMETHING");
            Damage(target);
            GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectIns, 3f);



        }
        void Damage(Transform enemy)
        {
            EnemyHealth e = enemy.GetComponent<EnemyHealth>();

            if (e != null)
            {
            
            }

            Destroy(gameObject);
        }


        //target lock on
        if (target != null)
        {
            *//*Vector2 dir = target.position - transform.position;*//*
            Quaternion lookRotation = Quaternion.LookRotation(dir);
        }

        if (target != null && fireCountdown <= 0f)
        {
            GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            //GameObject bulletGo2 = (GameObject)Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            swing1 bullet = bulletGo.GetComponent<swing1>();
            //Bullet bullet2 = bulletGo2.GetComponent<Bullet>();

            if (bullet != null) { }
               *//* bullet.Seek(target);*//*
        }
    }
    public void Seek(Transform _target)
    {
        target = _target;
    }
   

    }


*/