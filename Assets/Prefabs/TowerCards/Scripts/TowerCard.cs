using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerCard : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public GameObject towerInstance;
    public GameObject towerDragInstance;
    public GameObject towerCardInstance;
    public Canvas canvas;

    public void OnDrag(PointerEventData eventData)
    {
        towerDragInstance.transform.position = Input.mousePosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        towerDragInstance = Instantiate(towerInstance, canvas.transform);
        towerDragInstance.transform.position = Input.mousePosition;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        towerDragInstance.transform.position = Input.mousePosition;
    }
}