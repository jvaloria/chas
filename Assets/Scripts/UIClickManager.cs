using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class UIClickManager : MonoBehaviour
{
    private GraphicRaycaster _graphicRaycaster;
    private PointerEventData _pointerEventData;
    private EventSystem _eventSystem;

    private void Start()
    {
        // Find the GraphicRaycaster. It's usually on the Canvas.
        var canvas = GetComponentInParent<Canvas>();
        if (canvas)
        {
            _graphicRaycaster = canvas.GetComponent<GraphicRaycaster>();
        }

        if (!_graphicRaycaster)
        {
            Debug.LogError("UIClickManager: Could not find a GraphicRaycaster. Please ensure this script is on or under a Canvas, or that a GraphicRaycaster is present on the Canvas.");
            enabled = false; // Disable this script if setup fails
            return;
        }

        // Get the current EventSystem
        _eventSystem = EventSystem.current;
        if (!_eventSystem)
        {
            Debug.LogError("UIClickManager: No EventSystem found in the scene. Please add one (usually automatically added with a Canvas).");
            enabled = false; // Disable this script if setup fails
        }
    }

    private void Update()
    {
        // Don't proceed if essential components are missing
        if (!_graphicRaycaster || !_eventSystem)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            // Create a PointerEventData object for the current event system
            _pointerEventData = new PointerEventData(_eventSystem);
            // Set its position to the current mouse position
            _pointerEventData.position = Input.mousePosition;

            // Create a list to store the results of the raycast
            List<RaycastResult> results = new List<RaycastResult>();

            // Perform the raycast using the GraphicRaycaster
            _graphicRaycaster.Raycast(_pointerEventData, results);

            // Check if any UI element was hit
            if (results.Count > 0)
            {
                // The first result (results[0]) is typically the topmost UI element hit.
                var clickedUiElement = results[0].gameObject;

                // Try to get the InteractableObject component from the clicked UI element
                var interactable = clickedUiElement.GetComponent<InteractableObject>();

                if (interactable)
                {
                    // If the InteractableObject script is found, call its onClick method
                    interactable.OnClick();
                }
                /* Use this to see what was clicked if it wasn't an InteractableObject
                // else
                // {
                //     Debug.Log("Clicked on UI element: " + clickedUiElement.name + ", but it doesn't have an InteractableObject script.");
                 }*/
            }
        }
    }
}
