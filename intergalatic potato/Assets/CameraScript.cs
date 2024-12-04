using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private CinemachineVirtualCamera vcam;
    void Start()
    {
        var vcam = GetComponent<CinemachineVirtualCamera>();
        GameObject.FindGameObjectWithTag("Player").transform.position = this.transform.position;
        vcam.Follow = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {

    

    }
}
