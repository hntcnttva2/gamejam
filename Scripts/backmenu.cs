using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backmenu : MonoBehaviour
{
   public void back(){
        SceneManager.LoadScene("Menu");
   }
   
}
