using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 2f;
    private bool isLeft, isRight;
    CharacterController controller;

    private bool isFront, isBack;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 move = Vector3.zero;

        if (isLeft)
            move -= transform.right;
        if (isRight)
            move += transform.right;

        if (isFront)
            move += transform.forward;
        if (isBack)
            move -= transform.forward;

        controller.Move(move.normalized * speed * Time.deltaTime);
    }
    public void HoldFront() => isFront = true;
    public void ReleaseFront() => isFront = false;

    public void HoldBack() => isBack = true;
    public void ReleaseBack() => isBack = false;

    public void HoldRight() => isRight = true;
    public void ReleaseRight() => isRight = false;

    public void HoldLeft() => isLeft = true;
    public void ReleaseLeft() => isLeft = false;
}
