using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class priorityCam : MonoBehaviour
{
    public CinemachineVirtualCamera cinemachineVirtual;
    
    public void Update()
    {
        
    }
    public void Awake()
    {
        cinemachineVirtual = this.GetComponent<CinemachineVirtualCamera>();
    }
    public void priority9()
    {
        cinemachineVirtual.m_Priority = 9;
    }

    public void priority11()
    {
        cinemachineVirtual.m_Priority = 11;
    }
}
