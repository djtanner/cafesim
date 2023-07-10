using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
   

    public static string[] ingredientsInSlots = new string[3];

    

    public void OnDrop(PointerEventData eventData)
    {
        // Debug.Log("on drop");
        if (eventData.pointerDrag != null)
        {
            // Set the anchored position of the dropped item
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            // Get the index of the slot where the item is dropped
            int slotIndex = transform.GetSiblingIndex();

            // Store the name of the dropped item in the corresponding array element
            ingredientsInSlots[slotIndex] = eventData.pointerDrag.GetComponent<RectTransform>().name;

            Debug.Log("Dropped item name: " + ingredientsInSlots[slotIndex]);
        }

      

    }

    // TODO : add a button for submitting ingredients and check against the recipe of the card in the corner

    
}
