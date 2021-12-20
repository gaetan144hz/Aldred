using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
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
    public void camSwitcher(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            cinemachineVirtual.m_Priority = 9;
        }
        if (ctx.canceled)
        {
            cinemachineVirtual.m_Priority = 11;
            return;
        }
    }

}
