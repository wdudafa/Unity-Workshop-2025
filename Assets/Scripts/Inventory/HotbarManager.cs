using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarManager : MonoBehaviour
{
    public List<InventoryItem> hotbarSlots = new List<InventoryItem>();
    public InventoryManager inventoryManager;
    public Transform hotbarTransform;

    public int hotbarSize = 5;

    private void Start()
    {
        CreateInventorySlots();
    }
    private void CreateInventorySlots()
    {
        for (int i = 0; i < hotbarSize; i++)
        {
            InventoryItem item = Instantiate(inventoryManager.itemPrefab, hotbarTransform).GetComponent<InventoryItem>();
            item.Set(null, 0);
            hotbarSlots.Add(item);
        }
    }

    private void Update()
    {
        for(int i=0; i<hotbarSize; i++)
        {
            InventoryItem originalItem = inventoryManager.inventory[i];
            hotbarSlots[i].Set(originalItem.item, originalItem.quantity);
        }
    }

}
