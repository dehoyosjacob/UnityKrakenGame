using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FocusBar : MonoBehaviour
{
    [SerializeField] Slider focusBar;
    [SerializeField] int currentFocus;
    [SerializeField] int maxFocus;

    public levelController _levelController;

    private void Start()
    {
        currentFocus = 0;
        focusBar.maxValue = maxFocus;
        focusBar.minValue = 0;
    }

    public void IncreaseFocus(int value)
    {
        if(currentFocus < maxFocus)
        {
            currentFocus += value;
            focusBar.value = currentFocus;

            if (currentFocus >= maxFocus)
            {
                _levelController.ToggleFocusBar();
            }
        }
    }

    public void EmptyFocus()
    {
        if(currentFocus == maxFocus)
        {
            currentFocus = 0;
            focusBar.value = currentFocus;
            _levelController.ToggleFocusBar();
        }
    }
}
