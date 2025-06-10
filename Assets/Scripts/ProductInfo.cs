using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ProductInfo : MonoBehaviour
{
    public string productName;
    [TextArea(3, 10)]
    public string description;
    public Sprite productImage;
}
