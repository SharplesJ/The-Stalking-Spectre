using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckDead : MonoBehaviour
{
    
    public bool dead = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ghost")
        {
            dead = true;
            SceneManager.LoadScene("Death");
        }
    }
}
