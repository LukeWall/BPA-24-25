using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventorymain : MonoBehaviour
{
    public Craft craft;
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject crafted;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("craft"))
        {
            if (craft.invslot1.GetChild(1).CompareTag("Part1") && craft.invslot1.GetChild(2).CompareTag("Part1") && craft.invslot1.GetChild(3).CompareTag("Part1") && craft.invslot1.GetChild(4).CompareTag("Part1"))
            {
                Destroy(craft.invslot1.GetChild(1));
                Destroy(craft.invslot2.GetChild(2));
                Destroy(craft.invslot3.GetChild(3));
                Destroy(craft.invslot4.GetChild(4));
                Instantiate(craft.crafted, this.transform, true);
            }
        }
    }

}
