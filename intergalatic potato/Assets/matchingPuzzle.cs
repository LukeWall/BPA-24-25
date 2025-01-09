using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class matchingPuzzle : MonoBehaviour
{
    public GameObject puzzle;
    public Transform enlarged;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }
    public void enlargeimage1()
    {
        Debug.Log("yes");
        puzzle.transform.Equals(enlarged);
    }
  

}
