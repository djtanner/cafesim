using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameLogic : MonoBehaviour
{

    //Get the array from the itemslot script

    public ItemSlot itemSlot;
    public RandomItem randomItem;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void SubmitButtonClicked() {
        Debug.Log("clicked submit");

        
        if (ItemSlot.ingredientsInSlots[2] == "Marshmallow" && randomItem.textComponent.text == "Hot Cocoa")
        {
            Debug.Log("correct marshmallow");
        }
         else
        {
            Debug.Log("wrong recipe");
        }
    }
}
