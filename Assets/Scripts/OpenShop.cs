using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Animations;


public class OpenShop : MonoBehaviour
{
    public GameObject imageGO;
    public AnimationClip animationShop;
    public AnimationClip animationShopClose;

    public Button ShopButton;
    public TextMeshProUGUI stateShop;

    bool abrirTienda = false;

    Animation openShop;

    private void Start()
    {
        stateShop = ShopButton.GetComponentInChildren<TextMeshProUGUI>();
        openShop = GetComponent<Animation>();
        imageGO = GameObject.Find("Image");
        imageGO.SetActive(false);
    }

    public void AbrirTienda()
    {
        if (abrirTienda == false)
        {
            abrirTienda = true;
            stateShop.text = "Close Shop";
            imageGO.SetActive(true);
            openShop.clip = animationShop;
            openShop.Play();
        }
        else
        {
            abrirTienda = false;
            stateShop.text = "Open Shop";
            imageGO.SetActive(false);
            openShop.clip = animationShopClose;
            openShop.Play();
        }  
    }
}
