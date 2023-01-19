using System;
using UnityEngine;
using UnityEngine.UI;

public class SetInventory : MonoBehaviour
{
    [SerializeField]
    private RawImage imageItem;

    [SerializeField]
    private string nameItem;
    public string NameItem
    {
        get { return nameItem; }
    }

    [SerializeField]
    private Color imageInitialColor;

    public Action<string> OnGotItem = delegate { };

    private void Awake()
    {
        //GetComponent<GotCollected>().OnCollected += Inventory;
    }

    private void Inventory(string item)
    {
        if (string.Equals(nameItem, item))
        {
            imageItem.texture = GetComponent<SpriteRenderer>().sprite.texture;
            imageItem.color = GetComponent<SpriteRenderer>().color;

            OnGotItem?.Invoke(item);
        }
    }

    public void GetItemFromInventory()
    {
        imageItem.color = imageInitialColor;
    }

}
