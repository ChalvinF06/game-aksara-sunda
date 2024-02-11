using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lettercollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PLAYER1")
        {
            // if (GameManager.instance != null)
            // {
            //     GameManager.instance.scoreisup();
            // }
            GameManager.instance.scoreisup();
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "PLAYER2")
        {
            // if (GameManager.instance != null)
            // {
            //     GameManager.instance.scoreisup();
            // }
            GameManager.instance.scoreisup();
            Destroy(gameObject);
        }
    } 
}