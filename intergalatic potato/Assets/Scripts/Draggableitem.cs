using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class DragItem : MonoBehaviour, IDragHandler, IBeginDragHandler,
    IEndDragHandler
{
    private Vector3 _startingPosition;
    private Image _image;
    private Color _tempColor;
    private bool _isDropped = false;
    private Quaternion rotation;
    public Transform slot1;
    public Transform slot2;
    public Transform slot3;
    public Transform slot4;
    [HideInInspector]
    public int slot;
    private void Start()
    {
        _startingPosition = transform.position;
        rotation = this.rotation;
        _image = GetComponent<Image>();
        if (_image == null)
        {
            Debug.LogError("Image is Null!");
        }
    }

    public void ReturnToStartingPosition()
    {
        /*
         * Returns this object to original position
         * if not correct color in Drop Point 
         * or not on Drop Point
        */
        this.transform.position = _startingPosition;
    }

    public void IsDropped(bool dropped)
    {
        _isDropped = dropped;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        /*
         * This allows the raycaster to see objects underneath this one.
         * It is necessary for DropPoint to get information on this object.
         * OnDrop() method in DropPoint.cs
         * Also - If this is the correct item and the player tries to 
         * drag other items here, this item will be transparent and the DropPoint 
         * script will return the other object to starting position.
        */
        _image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {

        // Move this object to same position as pointer
        this.transform.position = eventData.position;
        this.transform.rotation = rotation;
        Debug.Log("dragging");
    }



    public void OnEndDrag(PointerEventData eventData)
    {
        /*
         * _isDropped will be true if correct item is dropped
         * on the Drop Point.  If _isDropped is true, we do
         * not want the object to return to starting position
        */
        if (slot == 0)
        {
            ReturnToStartingPosition();
            _image.raycastTarget = true;
        }
        if (slot == 1)
        {
            this.transform.position = slot1.position;
        }
        if (slot == 2)
        {
            this.transform.position = slot2.position;
        }
        if (slot == 3)
        {
            this.transform.position = slot3.position;
        }
        if (slot == 4)
        {
            this.transform.position = slot4.position;
            
        }
    }
        public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("slot1"))
        {
            slot = 1;
        }
        else if (other.CompareTag("slot2"))
        {
            slot = 2;
        }
        else if (other.CompareTag("slot3"))
        {
            slot = 3;
        }
        else if (other.CompareTag("slot4"))
        {
            slot = 4;
        }
        else
        {
            slot = 0;
        }

    }
}