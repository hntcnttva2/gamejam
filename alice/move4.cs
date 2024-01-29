using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class move4 : MonoBehaviour
{
    private float speed =2f;
    Transform playerMover;
    Animator anim;
    private int diem =0;
   
     public GameObject panel;
      public Button button;
      public GameObject panel1;
      public Button button1;
       public GameObject panel2;
      public Button button2;
       public GameObject panel3;
      public Button button3;
      public GameObject panel4;
      public Button button4;
    // Start is called before the first frame update
    void Start()
    {
        playerMover = gameObject.GetComponent<Transform>();
        anim = gameObject.GetComponent<Animator>();
        panel.SetActive(false); 
        button.gameObject.SetActive(false);
        panel1.SetActive(false); 
        button1.gameObject.SetActive(false);
        panel2.SetActive(false); 
        button2.gameObject.SetActive(false);
        panel3.SetActive(false); 
        button3.gameObject.SetActive(false);
        panel4.SetActive(false); 
        button4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            playerMover.Translate(Vector3.up * speed * Time.deltaTime);
            anim.SetInteger("status", 1);
        }else if(Input.GetKey(KeyCode.DownArrow)){
             playerMover.Translate(Vector3.down * speed * Time.deltaTime);
             anim.SetInteger("status", 2);
        }else if(Input.GetKey(KeyCode.RightArrow)){
            playerMover.Translate(Vector3.right * speed * Time.deltaTime);
             anim.SetInteger("status", 4);
        }else if(Input.GetKey(KeyCode.LeftArrow)){
            playerMover.Translate(Vector3.left * speed * Time.deltaTime);
            anim.SetInteger("status", 3);
        }else{
            anim.SetInteger("status", 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){  
        if(collision.gameObject.CompareTag("Key")){
                diem++;
              
                Destroy(collision.gameObject);

        }
        if(collision.gameObject.CompareTag("Card")){
            SceneManager.LoadScene("level4");
        }
        if(diem>2){
            if (collision.gameObject.CompareTag("Door")){
                SceneManager.LoadScene("Commu5");
            }
        }
         if (collision.gameObject.CompareTag("Paper"))
        {
            panel.SetActive(true);
            button.gameObject.SetActive(true);
        } if (collision.gameObject.CompareTag("Paper2"))
        {
            panel2.SetActive(true);
            button2.gameObject.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Paper3"))
        {
            panel3.SetActive(true);
            button3.gameObject.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Book"))
        {
            panel1.SetActive(true);
            button1.gameObject.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Gang"))
        {
            panel4.SetActive(true);
            button4.gameObject.SetActive(true);
        }
    }
}