using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpowerup : MonoBehaviour
{
    public GameObject powerupactivator;
    public Transform powerupspawner;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("instantiatepowerup",5f, 7f);
    }
    public void instantiatepowerpowerup()
    {
        Instantiate(powerupactivator,powerupspawner.transform.position, Quaternion.identity);
    }
}
