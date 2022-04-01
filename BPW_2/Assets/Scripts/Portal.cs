using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    public GameObject player;
    public Transform teleportLocation;
    public GameObject platform;
    

    private void OnTriggerEnter(Collider player)
    {
        Debug.Log("jeej");
        player.transform.position = teleportLocation.transform.position;
        platform.transform.position = new Vector3(platform.transform.position.x, 0.38f, platform.transform.position.z);
    }
}
