using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara2D : MonoBehaviour
{
    public Transform targetPlayer;

    void Start()
    {
        if (targetPlayer == null)
        {
            targetPlayer = GameObject.FindGameObjectWithTag("player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(targetPlayer.position.x + 6f, 0, -10);
    }
}
