using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ghost_AI : MonoBehaviour
{
    public float movementSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        //get player's position
        GameObject player = GameObject.Find("Player");
        Transform playerTransform = player.transform;
        Vector3 playerPosition = playerTransform.position;


        //get ghosts position
        GameObject ghost = GameObject.Find("Ghost");
        Transform ghostTransform = ghost.transform;
        Vector3 ghostPosition = ghostTransform.position;

        //move the ghost towards the player
        if ((playerPosition.x < ghostPosition.x) & (playerPosition.z < ghostPosition.z))
        {
            transform.position = transform.position + new Vector3(-movementSpeed * Time.deltaTime, 0, -movementSpeed * Time.deltaTime);
        }
        else if ((playerPosition.x > ghostPosition.x) & (playerPosition.z < ghostPosition.z))
        {
            transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, -movementSpeed * Time.deltaTime);
        }
        else if ((playerPosition.x < ghostPosition.x) & (playerPosition.z > ghostPosition.z))
        {
            transform.position = transform.position + new Vector3(-movementSpeed * Time.deltaTime, 0, movementSpeed * Time.deltaTime);
        }
        else if ((playerPosition.x > ghostPosition.x) & (playerPosition.z > ghostPosition.z))
        {
            transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, movementSpeed * Time.deltaTime);
        }
    }
}
