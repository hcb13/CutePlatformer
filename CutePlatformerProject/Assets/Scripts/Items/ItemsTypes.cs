using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsTypes : MonoBehaviour
{
    public enum Items
    {
        Strawberry,
        Melon,
        Key
    }

    public List<string> items = new List<string>{"Strawberry",
                                                 "Melon",
                                                 "Key"};
}
