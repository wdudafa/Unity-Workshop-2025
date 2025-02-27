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
    }

    private void CreateInventorySlots()
    {
        for (int i = 0; i < inventorySize; i++)
        {
            InventoryItem item = Instantiate(itemPrefab, inventoryTransform).GetComponent<InventoryItem>();
            inventory.Add(item);
        }
    }
}
