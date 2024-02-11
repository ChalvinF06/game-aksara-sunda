using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trans1 : MonoBehaviour
{
    // Start is called before the first frame update
     void Start()
    {
        StartCoroutine(nextlevel());
    }
    IEnumerator nextlevel()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Level1");
    }
}
