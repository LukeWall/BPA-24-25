using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.FindGameObjectWithTag("MainCamera").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
