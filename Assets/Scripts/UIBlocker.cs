using UnityEngine;
using UnityEngine.EventSystems;

public class UIBlocker : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool IsInteractingWithUI = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        IsInteractingWithUI = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        IsInteractingWithUI = false;
    }
}
