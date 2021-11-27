using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelController : MonoBehaviour
{
    [SerializeField] Image FocusBarFull;
    [SerializeField] Image gadgetSlot_1;
    [SerializeField] Image gadgetSlot_2;
    [SerializeField] Image gadgetSlot_3;
    [SerializeField] Image gadgetSlot_4;

    int slotsAvailable = 4;

    public void ToggleFocusBar()
    {
        if(FocusBarFull.gameObject.activeSelf)
        {
            FocusBarFull.gameObject.SetActive(false);
        }

        else
        {
            FocusBarFull.gameObject.SetActive(true);
        }
    }

    public void ToggleGadgetSlots()
    {
        if(slotsAvailable == 4)
        {
            gadgetSlot_4.gameObject.SetActive(false);
        }

        else if (slotsAvailable == 3)
        {
            gadgetSlot_3.gameObject.SetActive(false);
        }

        else if (slotsAvailable == 2)
        {
            gadgetSlot_2.gameObject.SetActive(false);
        }

        else if (slotsAvailable == 1)
        {
            gadgetSlot_1.gameObject.SetActive(false);
        }

        slotsAvailable--;
    }
       
}
