using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ItemDate", menuName = "ItemDate", order = 51)]
public class ItemDate : ScriptableObject 
{
    [SerializeField] private Sprite _preview;
    [SerializeField] private string _label;
    [SerializeField] private GameObject _prefab;

    public Sprite Preview => _preview;
    public string Lable => _label;

    public GameObject Prefab => _prefab;
}
