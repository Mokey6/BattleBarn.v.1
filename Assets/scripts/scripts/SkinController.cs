using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SkinController : MonoBehaviour
{
    public Animator anim;

    public LayerMask layerMask;
    public bool grounded;

    void Start()
    {

    }
    private void FixedUpdate()
    {

        Move();
    }

    private void Move()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");



        this.anim.SetFloat("vertical", verticalAxis);
        this.anim.SetFloat("horizontal", horizontalAxis);
    }
}
