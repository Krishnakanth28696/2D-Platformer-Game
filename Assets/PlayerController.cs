using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

    // void Start()
    // {
    //     animator = GetComponent<Animator>();
    // }

    // Update is called once per frame
    void Update()
    {
        float ss = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(ss));
        Vector3 scale = transform.localScale;
        if(ss < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }
        else
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;

    }
}
