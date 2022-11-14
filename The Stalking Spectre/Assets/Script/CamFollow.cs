using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        Transform playerTransform = player.transform;
        Vector3 playerPosition = playerTransform.position;

        Debug.Log(playerPosition);

        transform.position = playerPosition + new Vector3(0, 13, 0);
    }
}
