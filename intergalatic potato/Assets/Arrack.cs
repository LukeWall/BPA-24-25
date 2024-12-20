using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrack : MonoBehaviour
{
    private float spinSpeed = 1;
    private GameObject weapon;
    private GameObject hand;
    public float degreesPerSecond = 10.0f;
    public GameObject[] anim;
    private GameObject player;
    private int animCount;
    public Animation animation;
    public Animator animator;
    private bool attacking = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.FindGameObjectWithTag("weapon").GetComponent<Animator>();
        weapon = GameObject.FindGameObjectWithTag("weapon");
        //animation = weapon.gameObject.GetComponent<Animation>();
    }
    public void Attack()
    {
        
        animator = GameObject.FindGameObjectWithTag("weapon").GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        hand = GameObject.FindGameObjectWithTag("PlayerHand");
        weapon = GameObject.FindGameObjectWithTag("weapon");
        Debug.Log("YES");
        
        attacking= true;
        //animation.Play("Attack");
        //weapon.transform.Rotate(Vector3.back, spinSpeed, Space.World);
        //weapon.transform.Rotate(0, 0, -1000 * Time.deltaTime);
        animator.Play("TridentAttack");
        //GameObject.Instantiate(anim[0], weapon.transform, true);

        //weapon.transform.Translate(Vector2.up * 10 * Time.deltaTime, Space.World);
        //weapon.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime, Space.Self);

    }
    // Update is called once per frame
    //void Update()
    //{
        
    //    if (attacking == true) { 
    //        for (animCount=0; animCount < anim.Length - 1; animCount++)
    //            {
    //            int anim1 = 0;
    //                GameObject go = Instantiate(anim[anim1], player.transform, true);
    //                Destroy(go, 4);
    //            attacking = false;
    //            anim1++;
    //            }
    //    }

    //}
}
