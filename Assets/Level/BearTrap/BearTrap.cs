using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrap : MonoBehaviour
{
    public bool activated;
    public float activationError = 0.5f;
    private PlayerController player;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        // if (player.transform.position.y >= transform.position.y - activationError)
        // {
        //     activated = true;
        // }
        animator.SetBool("activated", activated);

    }
}
