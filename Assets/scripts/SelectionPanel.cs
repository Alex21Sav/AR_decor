using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionPanel : MonoBehaviour
{
    [SerializeField] private ItemDate[] _itemDates;
    [SerializeField] private ObjectPlacer _objectPlacer;
    [SerializeField] private GameObject _itemTemplate;
    [SerializeField] private Transform _cotainer;

    private void Start()
    {
        for (int i = 0; i < _itemDates.Length; i++)
        {
            AddItem(_itemDates[i]);
        }
    }

    private void AddItem(ItemDate itemDate)
    {
       Instantiate(_itemTemplate, _cotainer).TryGetComponent(out ItemVIew itemView);        
       itemView.Initialoze(itemDate);
        itemView.ItemSelected += OnItemSelected;
        itemView.ItemDisabled += OnItemDisabled;
    }

    private void OnItemSelected(ItemDate itemDate)
    {
        _objectPlacer.SetInstalledObject(itemDate);
    }

    private void OnItemDisabled(ItemVIew itemView)
    {
        itemView.ItemSelected -= OnItemSelected;
        itemView.ItemDisabled -= OnItemDisabled;
    }
}
