using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DropPoint : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private TMP_Text _instructioTtext;
    [SerializeField]
    private GameObject part;
    [SerializeField]
    private Transform slot;
    [SerializeField]
    private string _itemname; // These must match names of draggable items
    private string _currentColor;
   
    public GameObject ghostitem;
    private void Start()
    {
        _currentColor = this.name;
    }
    private void Update()
    {
      
    }
    public void ResetGame()
    {
        /*
         * Finds objects with DragItem script on them
         * Turns raycasting back on
         * Returns objects to starting position
        */
        var foundobjects = FindObjectsOfType<DragItem>();
        foreach (var obj in foundobjects)
        {
            obj.GetComponent<Image>().raycastTarget = true;
            /*
             * Item will return to starting position when dropped
             * unless correct item is in Drop Point
            */
            obj.IsDropped(false);
            obj.ReturnToStartingPosition();
        }

        
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.name == _currentColor) // Item name matches current color
        {
            //Instantiate ghost item for craft child count
            GameObject.Instantiate(ghostitem, this.transform);
            //// Snap to this location
            eventData.pointerDrag.transform.position = slot.position;
          
            // Stops Drag Item from returning item to starting position
            eventData.pointerDrag.GetComponent<DragItem>().IsDropped(true);

        }
        else // Item name does not match current color
        {
            // Turn on raycasting and return item to starting position
            eventData.pointerDrag.GetComponent<Image>().raycastTarget = true;
            eventData.pointerDrag.GetComponent<DragItem>().ReturnToStartingPosition();
        }
    }
}