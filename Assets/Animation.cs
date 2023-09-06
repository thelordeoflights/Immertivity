using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator playerAnim;
    Rigidbody playerRb;

    bool crouch = false;
    bool run = false;

    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // burpee = true;
            playerAnim.SetTrigger("Burp_trig");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            crouch = !crouch;
            playerAnim.SetBool("Crouch", crouch);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            run = !run;
            playerAnim.SetBool("Run", run);
        }

    }
}
