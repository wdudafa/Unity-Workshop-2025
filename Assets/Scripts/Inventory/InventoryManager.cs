using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem> inventory = new List<InventoryItem>();

    public int inventorySize = 15;

    [Header("References")]
    public GameObject itemPrefab;
    public Transform inventoryTransform;

    private void Start()
    {
        CreateInventorySlots();
        TestAddingItems();
    }

    private void CreateInventorySlots()
    {
        for (int i = 0; i < inventorySize; i++)
        {
            InventoryItem item = Instantiate(itemPrefab, inventoryTransform).GetComponent<InventoryItem>();
            item.Set(null, 0);
            item.OnDragItem += OnDragItem;
            inventory.Add(item);
        }
    }

    private void OnDragItem(InventoryItem item)
    {
        print("dw");
    }

    private void AddItemToInventory(ItemClass itemRef, int quantity)
    {
        //TO-DO check if there's space

        int index = inventory.FindIndex(i => i.item == null);
        inventory[index].Set(itemRef, quantity);
    }

    public InventoryItem currentItemBeingDragged = null;

    #region testing
    public ItemClass itemExample;
    private void TestAddingItems()
    {
        int quantity = 3;
        AddItemToInventory(itemExample, quantity);
    }
    #endregion
}
