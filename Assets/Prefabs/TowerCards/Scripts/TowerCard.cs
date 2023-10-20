using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerCard : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public GameObject towerInstance;
    private GameObject towerDragInstance;
    private GameObject towerCardInstance;
    public Canvas canvas;

    public void OnDrag(PointerEventData eventData)
    {
        // Check if towerDragInstance is not null to prevent errors
        if (towerDragInstance != null)
        {
            towerDragInstance.transform.position = Input.mousePosition;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Instantiate the towerDragInstance and store it in a variable
        towerDragInstance = Instantiate(towerInstance, Input.mousePosition, Quaternion.identity);
        towerDragInstance.transform.SetParent(canvas.transform, false);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Check if towerDragInstance is not null to prevent errors
        if (towerDragInstance != null)
        {
            // Perform any necessary logic when the pointer is released
            // For example, snapping the tower to a grid or checking if it's placed in a valid location

            // Destroy the drag instance since you've likely placed the tower
            Destroy(towerDragInstance);
        }
    }
}
