using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Mono.Cecil.Cil;
using UnityEngine.EventSystems;

public class RandomItem : MonoBehaviour, IPointerDownHandler
{

    public RecipeItemData[] recipeItems;
    //public string[] cafeItems = {"Hot Cocoa", "Cappuccino", "Espresso", "Latte", "Puppyccino",
    //"Double Espresso", "Iced Latte", "Spanish Latte", "Oat Milk Latte",
    //"Chai Latte", "Americano", "Cold Brew"};
    public TextMeshProUGUI textComponent;

    public RecipeItemData randomItem;
    public GameLogic gameLogic;



    // Start is called before the first frame update
    void Start()
    {
        if (textComponent == null)
        {
            textComponent = GetComponentInChildren<TextMeshProUGUI>();
        }

        if (textComponent != null && recipeItems.Length > 0)
        {
            getRandomItem();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPointerDown(PointerEventData eventData)
    {

        getRandomItem();
    }


    private void getRandomItem()
    {

        Debug.Log(recipeItems.Length);


         randomItem = recipeItems[Random.Range(0, recipeItems.Length)];

        gameLogic.AssignRandomItem(randomItem);
        textComponent.text = randomItem.itemName;

        

    }
    
}
