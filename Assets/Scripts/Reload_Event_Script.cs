using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Reload_Event_Script : MonoBehaviour
{
    //[SerializeField] private reload;
    // Start is called before the first frame update
    public int BulletReload;
    public void ReloadEvent()
    {
        Bullet_Manager.BulletNumber = BulletReload;
        Bullet_Manager.BulletText.SetText($"Amunition: {Bullet_Manager.BulletNumber} ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
