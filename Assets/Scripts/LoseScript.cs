using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript: MonoBehaviour
{
    public string Scenename;
    //public GameObject PlayerObject;

    //If collide with player, switch scenes
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(Scenename);
        }
    }
}