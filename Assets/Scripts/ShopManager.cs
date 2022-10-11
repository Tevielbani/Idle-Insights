using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject shopGameObject;
    public GameObject shopOKGameObject;
    public GameObject shopEKGameObject;
    public GameObject clicker;
    public bool shop = false;
    public bool shopOK = false;
    public bool shopEK = false;
    public bool clickerBool = true;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Shop()
    {
        shop = true;
        shopOK = false;
        shopEK = false;
        clickerBool = false;
    }
    public void ShopOK()
    {
        shop = false;
        shopOK = true;
        shopEK = false;
        clickerBool = false;
    }
    public void ShopEK()
    {
        shop = false;
        shopOK = false;
        shopEK = true;
        clickerBool = false;
    }

    public void CloseShop()
    {
        shop = false;
        shopOK = false;
        shopEK = false;
        clickerBool = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (shop == false)
        {
            shopGameObject.transform.position = new Vector2(540, 960);
            clicker.transform.position = new Vector2(540, 960);
        }
        if (shop == true)
        {
            shopGameObject.transform.position = new Vector2(0, 0);
            clicker.transform.position = new Vector2(0, 0);
        }
        if (shopOK == false)
        {
            shopOKGameObject.transform.position = new Vector2(540, 960);
            clicker.transform.position = new Vector2(540, 960);
        }
        if (shopOK == true)
        {
            shopOKGameObject.transform.position = new Vector2(0, 0);
            clicker.transform.position = new Vector2(0, 0);
        }
        if (shopEK == false)
        {
            shopEKGameObject.transform.position = new Vector2(540, 960);
            clicker.transform.position = new Vector2(540, 960);
        }
        if (shopEK == true)
        {
            shopEKGameObject.transform.position = new Vector2(0, 0);
            clicker.transform.position = new Vector2(0, 0);
        }
        if (clickerBool == true)
        {
            clicker.transform.position = new Vector2(0, 0);
        }
        if (clickerBool == false)
        {
            clicker.transform.position = new Vector2(540, 960);
        }
    }
}
