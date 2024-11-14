using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class EnemyController : MonoBehaviour
//{//three gameobjets bullet will spawn on
//    public GameObject player;
//    public float distanceBetween;
//    private float distance;
//    public bool moving = false;
//    public float speed;
//    //long range attack variables
//    private float shotCooldown;
//    public float startShotCooldown = 5;
//    public GameObject mageBullet;
    
//    public bool canAttack;
//    // Start is called before the first frame update
//    void Start()
//    {
//        shotCooldown = startShotCooldown;
//        canAttack = false;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        canAttack = false;
//        distance = Vector2.Distance(transform.position, player.transform.position);
//        Vector2 direction = player.transform.position - transform.position;
//        direction.Normalize();
//        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
//        //check if enemy is in distance
//        if(distance>distanceBetween)
//        {
//            //move the enemy
//             transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
//             moving = true;
//        }
//        if(shotCooldown <= 0 && moving==true)
//        {
//            Shoot(true);
//            shotCooldown = startShotCooldown;
//            canAttack = true;
//        }
//            shotCooldown -= Time.deltaTime;
//    }
//    [SerializeField]
//    private float mageBullet1YOffset, mageBullet1XOffset,mageBullet2YOffset,mageBullet2XOffset,mageBullet3YOffset,mageBullet3XOffset;
//    [SerializeField]
//    public GameObject firepoint1, firepoint2, firepoint3, firepoint4;
   
//    void Shoot(bool shoot)
//    {
//        if(shoot==true) 
//        {
//            Instantiate(mageBullet,new Vector3(firepoint1.transform.position.x, firepoint1.transform.position.y, 0),firepoint1.transform.rotation);
//            Instantiate(mageBullet, new Vector3(firepoint2.transform.position.x, firepoint2.transform.position.y, 0), firepoint2.transform.rotation);
//            Instantiate(mageBullet, new Vector3(firepoint3.transform.position.x, firepoint3.transform.position.y, 0), firepoint3.transform.rotation);
//            Instantiate(mageBullet, new Vector3(firepoint4.transform.position.x, firepoint4.transform.position.y, 0), firepoint4.transform.rotation);
//        }
//        else
//        {
//            return;
//        }
//    }
        
//    }
