using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    [SerializeField] private InventoryItem _item;

    private void OnMouseDown()
    {
        FindObjectOfType<InventoryController>().AddItem(_item);
    }
}
