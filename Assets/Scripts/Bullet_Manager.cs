using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class Bullet_Manager : MonoBehaviour
{
    public GameObject Bullets;

    static public int BulletNumber;
    public int RealBulletNumber;
    public float BulleteSpeed;
    //public int BulletReload;

    [SerializeField] private UnityEvent ReloadEvent;

    public static TextMeshProUGUI BulletText;

    private void Start()
    {
        //amount of bullets
        BulletNumber = RealBulletNumber;

        BulletText = GameObject.FindGameObjectWithTag("Bullet_Text").GetComponent<TextMeshProUGUI>();
        BulletText.SetText($"Amunition: {BulletNumber} ");
    }

    void Update()
    {
        //shooting mechanics
        if (Input.GetKeyDown(KeyCode.D) && BulletNumber >= 1)
        {
            GameObject shot = Instantiate(Bullets, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            shot.GetComponent<Rigidbody2D>().AddForce(new Vector2(BulleteSpeed, 0));
            BulletNumber--;

            //Update Ammo
            BulletText.SetText($"Amunition: {BulletNumber} ");
        }

        //Reloading
        if (Input.GetKeyDown(KeyCode.R) && BulletNumber < 1)
        {
            ReloadEvent.Invoke();
            //BulletNumber = BulletReload; //Amount you want to be reloaded
        }
    }
}
