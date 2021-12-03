using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GadgetControllers : MonoBehaviour
{
    public Text webShooters;
    public Text impactWeb;
    public WebShooterController _webShooterController;
    public ImpactWebController _impactWebController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleGadgets()
    {
        if (webShooters.gameObject.activeSelf)
        {
            webShooters.gameObject.SetActive(false);
            impactWeb.gameObject.SetActive(true);
        }

        else if (impactWeb.gameObject.activeSelf)
        {
            impactWeb.gameObject.SetActive(false);
            webShooters.gameObject.SetActive(true);
        }
    }

    public void FireGadget()
    {
        if (webShooters.gameObject.activeSelf)
        {
            Debug.Log("Firing web shooters!");
            _webShooterController.FireWebShooter();
        }

        else if (impactWeb.gameObject.activeSelf)
        {
            Debug.Log("Firing impact web!");
            _impactWebController.FireImpactWeb();
        }
    }
}
