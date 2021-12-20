using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFPS : MonoBehaviour
{
    public GameObject fps;
    public void FPS(bool isShow)
    {
        gameObject.SetActive(isShow);
        Debug.Log(isShow);
    }
}
