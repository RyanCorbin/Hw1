using System.Collections;
using UnityEngine;
using System.Collections.Generic;


public class CameraController : MonoBehaviour
{

    private Vector3 offset;

    public GameObject player;


    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

}
