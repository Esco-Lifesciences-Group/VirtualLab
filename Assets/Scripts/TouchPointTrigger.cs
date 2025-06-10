using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPointTrigger : MonoBehaviour
{
    public string ProductName;
    public string ProductDesc;
    public Sprite ProductImage;

    public void OnTouchPointClicked()
    {
        ProductInfoPanel.Instance.Show(ProductName, ProductDesc, ProductImage);
    }
}
