using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRotate : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float MovSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.Self);

        float moveHori = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 moveDirect = new Vector3(moveHori, 0, moveVert);
        transform.Translate(moveDirect * MovSpeed * Time.deltaTime, Space.World);
    }
}