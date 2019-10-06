using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIElementDragger : MonoBehaviour
{
    public LayerMask draggableMask;
    private Vector2 offset;
    private bool dragging;

    private IDraggable target;
    private Transform targetTransform;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UpdateDragTarget();
            if(target != null)
            {
                target.PickUp();
                dragging = transform;
            }
        }
        else if(Input.GetMouseButtonUp(0) && target != null)
        {
            target.PlaceDown();
            target = null;
            dragging = false;
        }

        if (dragging)
        {
            targetTransform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    public void UpdateDragTarget()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current)
        {
            pointerId = -1,
        };

        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);

        for (int i = 0; i < results.Count; i++)
        {
            if (draggableMask == (draggableMask | ( 1<< results[i].gameObject.layer)))
            {
                target = results[i].gameObject.GetComponent<IDraggable>();
                if (target != null)
                {
                    targetTransform = results[i].gameObject.transform;
                    offset = targetTransform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    break;
                }
            }
        }
    }
}