using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchControls : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Button buttonLeft, buttonRight, buttonForward, buttonBack;
    private Rigidbody rb;
    private Vector3 moveDirection;
    //private bool isMoving;

    /*public void OnPointerDown(PointerEventData eventData)
    {
        isMoving = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isMoving = false;
    }*/

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        buttonLeft.gameObject.AddComponent<ButtonPressHandler>().Initialize(SetMoveDirection, Vector3.left);
        buttonRight.gameObject.AddComponent<ButtonPressHandler>().Initialize(SetMoveDirection, Vector3.right);
        buttonForward.gameObject.AddComponent<ButtonPressHandler>().Initialize(SetMoveDirection, Vector3.forward);
        buttonBack.gameObject.AddComponent<ButtonPressHandler>().Initialize(SetMoveDirection, Vector3.back);
    }

    // Update is called once per frame
    void Update()
    {
        if (moveDirection!=Vector3.zero)
        {
            MovePlayer();
        }
    }

    private void SetMoveDirection(Vector3 direction)
    {
        moveDirection = direction;
    }

    private void MovePlayer()
    {
        rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);
    }
}

