using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Mono.Cecil.Cil;
using UnityEngine.EventSystems;

public class RandomItem : MonoBehaviour, IPointerDownHandler
{

    public string[] cafeItems = {"Hot Cocoa", "Cappuccino", "Espresso", "Latte", "Puppyccino",
    "Double Espresso", "Iced Latte", "Spanish Latte", "Oat Milk Latte",
    "Chai Latte", "Americano", "Cold Brew"};
    public TextMeshProUGUI textComponent;
    

    // Start is called before the first frame update
    void Start()
    {
        if (textComponent == null)
        {
            textComponent = GetComponentInChildren<TextMeshProUGUI>();
        }

        if (textComponent != null)
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
       string randomItem = cafeItems[Random.Range(0, cafeItems.Length)];

        textComponent.text = randomItem;
    }

}
