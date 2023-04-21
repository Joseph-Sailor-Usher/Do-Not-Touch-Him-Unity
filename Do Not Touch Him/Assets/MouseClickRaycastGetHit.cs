using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using static UnityEngine.InputSystem.InputAction;
using UnityEngine.Events;
using UnityEngine.Experimental;
using UnityEngine.Experimental.GlobalIllumination;

public class MouseClickRaycastGetHit : MonoBehaviour
{
    public UnityEvent monkecyClicked;
    public Default_ control;
    [SerializeField] private Camera camera; // reference to the Camera component

    private void OnEnable() => control.Enable();
    private void OnDisable() => control.Disable();

    public void Awake()
    {
        control = new();
        control.Default.Click.performed += OnPointerDown;
    }

    private void OnPointerDown(CallbackContext context)
    {
        Vector3 screenCoordinates = Mouse.current.position.ReadValue();
        Ray ray = camera.ScreenPointToRay(screenCoordinates); // create a ray from the screen point to the world point of the click
        if (Physics.Raycast(ray, out RaycastHit hitInfo)) // check if any colliders are hit by the ray
        {
            Debug.Log("Hit object: " + hitInfo.collider.gameObject.name); // log the name of the hit GameObject
            if(hitInfo.collider.transform.name == "MrMo_A")
            {
                Debug.Log("Clicked him");
                monkecyClicked.Invoke();
            }
        }
    }
}
