using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelPortal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "PLAYER1")
        {
            SceneManager.LoadScene("transtolvl2");
        }
        if(col.gameObject.tag == "PLAYER2")
        {
           SceneManager.LoadScene("win");
        }
    }
}
