using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craftBtn : MonoBehaviour
{
    public GameObject UI;
    public int count;
    Inventorymain inventory;
    Transform[] slot = new Transform[6];
    Transform[] slotChild = new Transform[6];
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventorymain>();
        slotChild[1] = slot[1].transform.GetChild(1);
        slotChild[2] = slot[2].transform.GetChild(1);
        slotChild[3] = slot[3].transform.GetChild(1);
        slotChild[4] = slot[4].transform.GetChild(1);
        slotChild[5] = slot[5].transform.GetChild(1);
        slotChild[6] = slot[6].transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void check()
    {
        for (int i = 0; i < slot.Length; i++) {
            if (slotChild[i].CompareTag("Part1") || slotChild[i].CompareTag("Part2") || slotChild[i].CompareTag("Part3") || slotChild[i].CompareTag("Part4"))
            {
                count++;
                slotChild[i].tag = ".";
            }
            else
            {
                return;
            }
        }
        if (count == 4)
        {
            GameObject.Instantiate(UI);
        }
        else return;
        
    }

}
