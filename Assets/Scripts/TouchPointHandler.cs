using UnityEngine;
using UnityEngine.UI;

public class TouchPointHandler : MonoBehaviour
{
    public ProductInfo productInfo;
    public ProductInfoUI productInfoUI;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        productInfoUI.ShowProductInfo(productInfo);
    }
}
