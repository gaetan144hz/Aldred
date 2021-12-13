using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LadderSpawn : MonoBehaviour
{
    [SerializeField] private GameObject ladder;

    [SerializeField] private Transform spawnPoint;

    public void OnSpawn(InputValue value)
    {
        if (value.isPressed)
        {
            ladderSpawn();
            return;
        }
    }

    public void ladderSpawn()
    {
        Instantiate(ladder, new Vector3(spawnPoint.position.x + 5, spawnPoint.position.y + 3), Quaternion.identity);
    }
}
