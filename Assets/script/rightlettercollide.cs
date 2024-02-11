using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightlettercollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "rightletter")
        {
            GameManager.instance.scoreisup();
            GameManager.instance.lettersound();
        }
        if(col.gameObject.tag == "wrongletter")
        {
            GameManager.instance.lifedecrease();
            GameManager.instance.wronglettersound();
        }
    }
}
