using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plungerfire : MonoBehaviour
{
    public GameObject m_ArrowPrefab;
    public float m_FiringForce = 10f;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Quaternion arrowRotation = Quaternion.LookRotation(transform.forward, Vector3.up);

            GameObject tempRef = Instantiate<GameObject>(m_ArrowPrefab, transform.position + (transform.forward * cam.nearClipPlane * 2f), arrowRotation);

            Vector3 direction = transform.forward;
            tempRef.GetComponent<Rigidbody>().AddForce(direction * m_FiringForce, ForceMode.Impulse);
        }
    }


    private Vector2 GetMouseScreenPos()
    {
        return new Vector2((Input.mousePosition.x / Screen.width) - 0.5f, (Input.mousePosition.y / Screen.height) - 0.5f);
    } 
}
