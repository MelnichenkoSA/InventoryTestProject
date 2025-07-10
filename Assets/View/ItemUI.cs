using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private Text _nameText;
    [SerializeField] private Text _descriptionText;
    [SerializeField] private Button _removeButton; 
    [SerializeField] private GameObject _descriptionPanel;

    private InventoryItem _currentItem;

    public InventoryItem GetItem() => _currentItem;
    public void Setup(InventoryItem item)
    {
        _currentItem = item;
        _icon.sprite = item.Icon;
        _nameText.text = item.Name;
        _descriptionText.text = item.Description;

        if (_removeButton != null)
        {
            _removeButton.onClick.RemoveAllListeners(); 
            _removeButton.onClick.AddListener(RemoveItem);
        }
        else
        {
            Debug.LogError("Кнопка удаления не назначена!", this);
        }
    }

    public void RemoveItem()
    {
        var controller = FindObjectOfType<InventoryController>();
        if (controller != null && _currentItem != null)
        {
            controller.RemoveItem(_currentItem); 
            Destroy(gameObject); 
        }
    }
    public void OpenDescription()
    {
        if(_descriptionPanel.gameObject.activeSelf == true)
            _descriptionPanel.SetActive(false);
        else
            _descriptionPanel.SetActive(true);
    }

}
