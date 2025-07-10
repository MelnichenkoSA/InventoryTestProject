using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryController : MonoBehaviour
{
    [SerializeField] private List<InventoryItem> _items = new();
    private const int MaxSlots = 3;

    public event System.Action<List<InventoryItem>> OnInventoryChanged;

    public void AddItem(InventoryItem item)
    {
        if (_items.Count >= MaxSlots)
        {
            Debug.Log("Инвентарь полон! Максимум " + MaxSlots + " слота.");
            return;
        }

        InventoryItem newItem = ScriptableObject.Instantiate(item);
        _items.Add(newItem);
        OnInventoryChanged?.Invoke(new List<InventoryItem>(_items));
    }

    public void RemoveItem(InventoryItem item)
    {
        _items.Remove(item);
        OnInventoryChanged?.Invoke(new List<InventoryItem>(_items));
    }
}
