using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Item")]

public class ItemsScript : ScriptableObject
{
    public string Name;
    public bool stackable;
    public Sprite icon;
}
