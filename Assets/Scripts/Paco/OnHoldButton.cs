using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class OnHoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public UnityEvent OnHold;
    bool IsHolding;
    public int timehold=0;

    public void OnPointerDown(PointerEventData eventData)
    {
        IsHolding = true;
        timehold++;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        IsHolding = false;
    }


    void Update()
    {
        if (IsHolding)
        {
            OnHold.Invoke();
        }
    }

}
