using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinscript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Coin destroys itself when touched
        Destroy(gameObject);
    }
}
