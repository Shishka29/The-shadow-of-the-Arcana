using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 pos;
    private Vector3 velocity;
    public float smoothTime = 0.2f;
    public float minCameraHeight = -3.5f;


    private void Awake()
    {
        if (!player)
        {
            player = FindObjectOfType<Hero>().transform;
        }
    }

    private void Update()
    {
        pos = player.position;
        pos.z = -10f;
        

        if (pos.y < minCameraHeight)
        {
            pos.y = minCameraHeight;
        }


        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smoothTime);
    }
}

