using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   public void gototranslvl1()
   {
    SceneManager.LoadScene("transtolvl1");
   }
   public void quitgame()
   {
    Application.Quit();
   }

   public void gotomenu()
   {
    SceneManager.LoadScene("Mainmenu");
   }
   public void gototentang()
   {
    SceneManager.LoadScene("Tentang");
   }
   public void gotomember()
   {
    SceneManager.LoadScene("Member");
   }
   public void gotoanggota()
   {
    SceneManager.LoadScene("anggota");
   }
}
