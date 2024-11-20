using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class DragItem : MonoBehaviour, IDragHandler, IBeginDragHandler,
    IEndDragHandler
{
    DropPoint droppoint;
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
        if (!_isDropped)
        {
            ReturnToStartingPosition();
            _image.raycastTarget = true;
        }
    
    }
       
}