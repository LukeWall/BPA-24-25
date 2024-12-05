using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float traverseSpeed = 2f;
    Rigidbody2D rb;
    Transform target;
    Vector2 walkingDirection;

    float health, maxHealth = 3f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            rb.velocity = new Vector2(walkingDirection.x, walkingDirection.y)* traverseSpeed;
        }
    }

    public void TakingDamage(float damage)
    {
        health -= damage;
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }
}
