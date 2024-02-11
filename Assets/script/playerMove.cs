using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerMovespeed = 8f;
    [SerializeField]
    float maxX;

    float moveX;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        moveX = Input.GetAxis("Horizontal") * playerMovespeed * Time.deltaTime;
        transform.position += new Vector3(moveX, 0, 0);
        float maxPos = Mathf.Clamp(transform.position.x, -maxX, maxX);
        transform.position = new Vector3(maxPos, transform.position.y, transform.position.z);
    } 
}
