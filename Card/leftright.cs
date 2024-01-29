using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftright : MonoBehaviour
{
    public  float speed = 1f;
    public float right =4f;
    public float left = 2f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*speed*Time.deltaTime);
        if(transform.position.x>right){
            speed = -speed;
            anim.SetInteger("status",0);
        }
        if(transform.position.x<left){
            speed = Mathf.Abs(speed);
            anim.SetInteger("status",1);
        }
    }
}
