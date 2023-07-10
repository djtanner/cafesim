using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class GameLogic : MonoBehaviour
{

    //Get the array from the itemslot script

    public ItemSlot itemSlot;
    //public RandomItem randomItemScript;

    [SerializeField]
    private RecipeItemData randomItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AssignRandomItem(RecipeItemData item)
    {
        randomItem = item;
    }


    public void SubmitButtonClicked() {
        Debug.Log("clicked submit");
        

        //if (ItemSlot.ingredientsInSlots[2] == "Marshmallow" && randomItem.textComponent.text == "Hot Cocoa")
        //{
        //    Debug.Log("correct marshmallow");
        //}
        // else
        //{
        //    Debug.Log("wrong recipe");
        //}


        if (checkRecipeMatch(ItemSlot.ingredientsInSlots, randomItem))
        {
            Debug.Log("recipe matched");
        }
        else {
            Debug.Log("not a match");
        }

    }

    private bool checkRecipeMatch(string[] recipeDropped, RecipeItemData recipe) {
        
        var recipeIngredientNames = recipe.ingredients;

        bool areEqual = recipeDropped.Length == recipeIngredientNames.Length && recipeDropped.All(recipeIngredientNames.Contains);

        return areEqual;

    }
}
