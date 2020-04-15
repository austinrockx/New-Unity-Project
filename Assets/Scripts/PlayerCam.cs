using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public GameObject player;

    //changes the camera postion to above the vehicle
    private Vector3 offset = new Vector3(0, 7, -9);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Make the cam follow the vehicle
        transform.position = player.transform.position + offset;
    }
}
