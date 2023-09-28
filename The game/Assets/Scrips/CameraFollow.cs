using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    public  Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        offset = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position - offset;
    }
}
