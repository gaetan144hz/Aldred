using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescaler : MonoBehaviour
{
    public bool isButtonPressed;

    public Coroutine couroutineScaler;

    public Rigidbody2D rb;

    private void Start()
    {
        startCoroutine();
        rb = this.GetComponent<Rigidbody2D>();
    }

    public void startCoroutine()
    {
        couroutineScaler = StartCoroutine(scaler());
        //isButtonPressed = true;
    }

    public void stopCoroutine()
    {
        //isButtonPressed = false;
        StopCoroutine(couroutineScaler);
    }

    private IEnumerator scaler()
    {
        while (isButtonPressed)
        {
            this.transform.localScale = new Vector3(0, 1, 0);
            yield return null;
        }
    }
}
