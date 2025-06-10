using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProductInfoUI : MonoBehaviour
{
    public static ProductInfoUI Instance;

    public GameObject infoPanel;
    public TextMeshProUGUI productNameText;
    public TextMeshProUGUI descriptionText;
    public Image productImage;

    private void Awake()
    {
        Instance = this;
        infoPanel.SetActive(false);
    }

    public void ShowProductInfo(ProductInfo info)
    {
        productNameText.text = info.productName;
        descriptionText.text = info.description;
        productImage.sprite = info.productImage;

        infoPanel.SetActive(true);
    }

    public void HideProductInfo()
    {
        infoPanel.SetActive(false);
    }
}
