using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCursor : MonoBehaviour
{
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        Vector3 point = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 13));

        float t = cam.transform.position.y / (cam.transform.position.y - point.y);
        Vector3 finalPoint = new Vector3(t * (point.x - cam.transform.position.x) + cam.transform.position.x, 1, t * (point.z - cam.transform.position.z) + cam.transform.position.z);


        transform.LookAt(point, Vector3.up);

        //Vector2 playerPos = cam.WorldToViewportPoint(transform.position);

        //Vector2 mousePos = Input.mousePosition;

        //Vector2 vector = (mousePos - playerPos).normalized;

        //Vector2 playerFacing = cam.WorldToViewportPoint(transform.forward);

        //playerPos.Normalize();

        //float angle = Mathf.Acos((vector.x *))
    }
}
