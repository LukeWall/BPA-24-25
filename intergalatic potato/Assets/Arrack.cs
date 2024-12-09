using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrack : MonoBehaviour
{
    private float spinSpeed = 1;
    private GameObject weapon;
    public float degreesPerSecond = 10.0f;
    public GameObject[] anim;
    private GameObject player;
    private int animCount;
    Animation animation;
    private Animator animator;
    private bool attacking = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Attack()
    {
        animation = this.gameObject.GetComponent<Animation>();
        animator =GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        weapon = GameObject.FindGameObjectWithTag("PlayerHand");
        Debug.Log("YES");
        attacking= true;
        animation.Play();
        //weapon.transform.Rotate(Vector3.back, spinSpeed, Space.World);
        weapon.transform.Rotate(0, 0, -1000 * Time.deltaTime);
        
        //GameObject.Instantiate(anim[0], weapon.transform, true);
        
        //weapon.transform.Translate(Vector2.up * 10 * Time.deltaTime, Space.World);
        //weapon.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime, Space.Self);

    }
    // Update is called once per frame
    void Update()
    {
        
        if (attacking == true) { 
            for (animCount=0; animCount < anim.Length - 1; animCount++)
                {
                int anim1 = 0;
                    GameObject go = Instantiate(anim[anim1], player.transform, true);
                    Destroy(go, 4);
                attacking = false;
                anim1++;
                }
        }

    }
}
