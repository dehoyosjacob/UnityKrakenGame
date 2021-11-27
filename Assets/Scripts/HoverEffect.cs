using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverEffect : MonoBehaviour
{
    [SerializeField] Image gadgetMenu;

    void OnMouseOver()
    {
        gadgetMenu.gameObject.SetActive(true);
        Debug.Log("Mouse is hovering");
    }

    void OnMouseExit()
    {
        gadgetMenu.gameObject.SetActive(false);
    }

}
