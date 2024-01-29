using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backfront : MonoBehaviour
{
    public  float speed = 1f;
    public float up =-2f;
    public float down = -4f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*speed*Time.deltaTime);
        if(transform.position.y>up){
            speed = -speed;
            anim.SetInteger("status",1);
        }
        if(transform.position.y<down){
            speed = Mathf.Abs(speed);
            anim.SetInteger("status",0);
        }
    }
}
