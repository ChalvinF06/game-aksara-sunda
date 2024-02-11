using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score = 0;
    public Text scoretext;
    int life = 5;
    public Text lifepoint;
    public GameObject gameoverspr, winnerspr, portalspr, homespr, resetspr;
    [SerializeField]
    AudioSource correctlettersfx, wronglettersfx, gameoversfx;

    void Awake()
    {
        if(instance == null)
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameoverspr.SetActive(false);
        winnerspr.SetActive(false);
        portalspr.SetActive(false);
        // homespr.SetActive(false);
        // resetspr.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void scoreisup()
    {
        score++;
        scoretext.text = score.ToString();

        if(score == 10)
        {
            winnerspr.SetActive(true);
            portalspr.SetActive(true);

        }
    }
    
    public void lifedecrease()
    {
        life--;
        lifepoint.text = life.ToString();

        if(life == 0)
        {
            gameoversfx.Play();
            gameoverspr.SetActive(true);
            // homespr.SetActive(true);
            // resetspr.SetActive(true);
        }
    }
    public void homebutton()
    {
        SceneManager.LoadScene("Mainmenu");
    }
    public void resetgame1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void resetgame2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void lettersound()
    {
        correctlettersfx.Play();
    }
    public void wronglettersound()
    {
        wronglettersfx.Play();
    }
    public void gameoversound()
    {
        gameoversfx.Play();
    }
}
