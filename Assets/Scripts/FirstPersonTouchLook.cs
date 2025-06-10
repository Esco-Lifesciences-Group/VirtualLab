using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonTouchLook : MonoBehaviour
{
    public float sensitivity = 0.1f;
    public Transform cameraTransform;
    float rotationX = 0f;

    void Update()
    {
        #if UNITY_EDITOR
                if (Input.GetMouseButton(0) && !UIBlocker.IsInteractingWithUI)
                {
                    float deltaX = Input.GetAxis("Mouse X") * sensitivity * 10f;
                    float deltaY = Input.GetAxis("Mouse Y") * sensitivity * 10f;

                    transform.Rotate(0, deltaX, 0);
                    rotationX -= deltaY;
                    rotationX = Mathf.Clamp(rotationX, -80f, 80f);
                    cameraTransform.localRotation = Quaternion.Euler(rotationX, 0, 0);
                }
        #else
            if (Input.touchCount == 1 && !UIBlocker.IsInteractingWithUI)
            {
                Touch t = Input.GetTouch(0);
                if (t.phase == TouchPhase.Moved)
                {
                    float deltaX = t.deltaPosition.x * sensitivity;
                    float deltaY = t.deltaPosition.y * sensitivity;

                    transform.Rotate(0, deltaX, 0);
                    rotationX -= deltaY;
                    rotationX = Mathf.Clamp(rotationX, -80f, 80f);
                    cameraTransform.localRotation = Quaternion.Euler(rotationX, 0, 0);
                }
            }
        #endif

    }


    bool IsPointerOverUI()
    {
        #if UNITY_EDITOR
                return EventSystem.current.IsPointerOverGameObject();
        #else
            if (Input.touchCount > 0)
            {
                int fingerId = Input.GetTouch(0).fingerId;
                return EventSystem.current.IsPointerOverGameObject(fingerId);
            }
            return false;
        #endif
    }



}
