using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawn : MonoBehaviour
{
    public Transform letterspawn;
    public GameObject[] letters;
    public float minposX, maxposX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("letterfall", 1f, 2f);
    } 

    void letterfall()
    {
        int randomletter = Random.Range(0, letters.Length);
        float randompos = Random.Range(minposX, maxposX);
        Vector3 randowmvectorpos = new Vector3(randompos, transform.position.y, transform.position.z);
        Instantiate(letters[randomletter], randowmvectorpos, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
