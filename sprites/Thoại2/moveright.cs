using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class moveright : MonoBehaviour
{
    private float speed =1f;
    Transform playerMover;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        playerMover = gameObject.GetComponent<Transform>();
        anim = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
         playerMover.Translate(Vector3.right * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision){  
       
        if(collision.gameObject.CompareTag("DuuDee")){
            SceneManager.LoadScene("Commu2");
        }
        
    }
}