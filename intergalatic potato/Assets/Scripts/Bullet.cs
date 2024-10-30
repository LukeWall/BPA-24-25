using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    //move the bullet
    void Update()
    {

        transform.Translate(new Vector3(0, 1f, 0) * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Destroy(gameObject);
    }
}
    

