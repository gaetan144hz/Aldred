using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class SpawnAtMouse : MonoBehaviour
{
    [SerializeField] GameObject ladderPrefab = null;
    private Camera cam = null;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        SpawnAtMousePos();
    }

    private void SpawnAtMousePos()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                Instantiate(ladderPrefab, new Vector3(hit.point.x,hit.point.y + ladderPrefab.transform.position.y, hit.point.z),Quaternion.identity);
            }
        }
    }
}
