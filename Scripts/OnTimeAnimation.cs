using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OneTimeAnimation : MonoBehaviour
{
    private Animator animator;
    private bool hasPlayed = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !hasPlayed)
        {
            animator.SetTrigger("end");
            hasPlayed = true;
        }
    }
}

