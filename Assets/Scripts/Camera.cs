using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(5, 1, -5);
    }
}