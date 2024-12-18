using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TridentAttack : MonoBehaviour
{
    private HealthManager enemyHealthManager;
    private GameObject weapon;
    public bool Attacking = false;
    [SerializeField] private Animation anim;
    [SerializeField] private float meleeSpeed;
    [SerializeField] private float Damage;
    public Animation anim1;
    public Input Input;
    private EnemySpawner enemy;
    public void Start()
    {
        Attacking = false;
        weapon = GameObject.FindGameObjectWithTag("weapon");
        anim1 = GameObject.FindGameObjectWithTag("weapon").GetComponent<Animation>();
    }
   

    private void Update()
    {
        
        //while(anim1.isPlaying == false)
        //{
        //    Attacking = false;
        //    Debug.Log("noAnimate");
        //}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("spacebar");
            anim1.Play("TridentAttack", PlayMode.StopSameLayer);
            Debug.Log("spacebar");
        }
        Attacking = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            Debug.Log("Enemy hit");
            enemy = other.GetComponent<EnemySpawner>();
            enemyHealthManager = other.GetComponent<HealthManager>();
            enemyHealthManager.HurtPlayer(10);
        }
    }

}
