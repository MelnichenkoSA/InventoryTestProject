using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryView : MonoBehaviour
{
    [SerializeField] private Transform _itemsParent;
    [SerializeField] private GameObject _itemUIPrefab;

    private void Start()
    {
        FindObjectOfType<InventoryController>().OnInventoryChanged += UpdateView;
    }

    private void UpdateView(List<InventoryItem> items)
    {
        foreach (Transform child in _itemsParent)
            Destroy(child.gameObject);

        foreach (var item in items)
        {
            var itemUI = Instantiate(_itemUIPrefab, _itemsParent);
            itemUI.GetComponent<ItemUI>().Setup(item);
        }
    }
}
