using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItem", menuName = "InventoryItems/BasicInventoryItem")]
public class InventoryItem : ScriptableObject
{
    [SerializeField] protected string _name;
    [SerializeField] protected string _description;
    [SerializeField] protected Sprite _icon;

    public string Name => _name;
    public string Description => _description;
    public Sprite Icon => _icon;
}
