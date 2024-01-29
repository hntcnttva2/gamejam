using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   public void play(){
        SceneManager.LoadScene("Prologue1");
   }
   public void quit(){
    Application.Quit();
   }
}
