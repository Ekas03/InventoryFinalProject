using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/item")]
public class Item : ScriptableObject
{
    [Header("Gameplay")] 
    public int value;
    public TileBase tile;
    public ItemType type;
    public Vector2Int range = new Vector2Int(5, 4);
    [Header("UI")]
    public bool stackable = true;
    [Header("Gameplay and UI")]
    public Sprite image;
    public enum ItemType
    {
        Food,
        XP,
        Tool,
        BuildingMaterial
    }
}
