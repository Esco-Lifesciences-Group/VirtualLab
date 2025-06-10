using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ProductInfoPanel : MonoBehaviour
{
    public static ProductInfoPanel Instance;

    public GameObject panel;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public Image productImage;


    private void Awake()
    {
        Instance = this;
        panel.SetActive(true);
    }

    public void Show(string title, string desc, Sprite image)
    {
        titleText.text = title;
        descriptionText.text = desc;
        productImage.sprite = image;
        panel.SetActive(true);
    }

    public void Hide()
    {
        panel.SetActive(false);
    }
}
