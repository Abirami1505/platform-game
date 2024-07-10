using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private System.Action<Vector3> setMoveDirection;
    private Vector3 direction;

    public void Initialize(System.Action<Vector3> setMoveDirection, Vector3 direction)
    {
        this.setMoveDirection = setMoveDirection; 
        this.direction = direction;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        setMoveDirection(direction);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        setMoveDirection(Vector3.zero);
    }
}
