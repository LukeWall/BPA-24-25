using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craft : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject final;
    public GameObject finalItem;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    // Start is called before the first frame update
    void Start()
    {
        //one.SetActive(false);
        //two.SetActive(false);
        //three.SetActive(false);
        //four.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(slot1.transform.childCount > 0 && slot2.transform.childCount >= 1 && slot3.transform.childCount >= 1 && slot4.transform.childCount >= 1)
            
        {
            //one.SetActive(true);
            //two.SetActive(true);
            //three.SetActive(true);
            //four.SetActive(true);
            final.SetActive(true);
           
        }
        else
        {
            final.SetActive(false);
            
        }
    }
}
