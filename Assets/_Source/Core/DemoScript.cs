using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsToPickup;

    public void PickupItem()
    {
        Item item = itemsToPickup[Random.Range(0, itemsToPickup.Length)];
        bool result = inventoryManager.AddItem(itemsToPickup[Random.Range(0, itemsToPickup.Length)]);
        if (result == true)
        {
            Debug.Log($"{item.name} added");
        }
        else
        {
            Debug.Log($"No space for {item.name}!");
        }
    }

    public void GetSelectedItem()
    {
        Item receivedItem = inventoryManager.GetSelectedItem(false);
        if (receivedItem != null)
        {
            Debug.Log($"Received item {receivedItem.name}");
        }
        else
        {
            Debug.Log("No item received!");
        }
    }
    
    public void UseSelectedItem()
    {
        Item receivedItem = inventoryManager.GetSelectedItem(true);
        if (receivedItem != null)
        {
            switch (receivedItem.type)
            {
                case Item.ItemType.Food:
                    Player.Instance.IncreaseHealth(receivedItem.value);
                    break;
                case Item.ItemType.XP:
                    Player.Instance.IncreaseExperience(receivedItem.value);
                    break;
                case Item.ItemType.Tool:
                    Debug.Log("Dug hole!");
                    break;
                case Item.ItemType.BuildingMaterial:
                    Debug.Log("Built pyramid!");
                    break;
            }
        }
        else
        {
            Debug.Log("No item to use!");
        }
    }
}
