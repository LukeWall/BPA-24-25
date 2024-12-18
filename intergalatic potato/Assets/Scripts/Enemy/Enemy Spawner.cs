using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class EnemySpawner : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float distanceBetween;
    private float distance;
    public bool moving;
    public Animator anim;
    private float nextFire;
    public Transform FirePoint;
    public float fireRate;
    public GameObject bulletPrefab;
    public float bulletForce;
    GameObject Bullet;
    Rigidbody2D rb;
    public float StartHP;
    public float currentHP;


    // Start is called before the first frame update
    void Start()
    {
        
        
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
         player = GameObject.FindGameObjectWithTag("Player");
        moving = true;
        var distance = Vector2.Distance(transform.position, player.transform.position);// no need to perform this operation twice.
        if (distance <  15 && distance > 8)
        {
            Vector2 direction = player.transform.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            anim.SetFloat("Speed", 2);
            
            
            
        }
        else
        {
            if (nextFire <= 0)
            {
                Shoot();
                nextFire = 1;
            }
            anim.SetFloat("Speed", 0);
        }
        if (nextFire > 0)
        {
            nextFire = nextFire -= Time.deltaTime;
        }
      if(moving == true)
        {
         
            
        }
        
    }
    void Shoot()
    {
        
        nextFire = 1;
        Bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
             rb = Bullet.GetComponent<Rigidbody2D>();
           
        
        Destroy(Bullet, 3f);
    }
   
}
