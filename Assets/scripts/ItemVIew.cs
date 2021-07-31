using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemVIew : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _lable;
    [SerializeField] private Button _selectionButton;

    private ItemDate _itemDate;

    public event UnityAction<ItemDate> ItemSelected;
    public event UnityAction<ItemVIew> ItemDisabled;

    private void OnEnable()
    {
        _selectionButton.onClick.AddListener(OnSelectionButtonClick);
    }

    private void OnDisable()
    {
        ItemDisabled?.Invoke(this);
        _selectionButton.onClick.RemoveListener(OnSelectionButtonClick);
    }

    private void OnSelectionButtonClick()
    {        
        ItemSelected?.Invoke(_itemDate);
    }

    public void Initialoze(ItemDate itemDate)
    {
        _itemDate = itemDate;
        _icon.sprite = itemDate.Preview;
        _lable.text = itemDate.Lable;

    }
}
