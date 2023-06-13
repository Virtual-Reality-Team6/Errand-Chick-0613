using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.UI;

public class XRControllerLeft : MonoBehaviour
{
    private ActionBasedController controller;

    public GameObject MemuGroup;
    public bool seeMenu;

    private void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }

    private void Update()
    {
        if (controller != null)
        {
            if (controller.selectAction.action.triggered)
            {
                if (seeMenu)
                {
                    MemuGroup.SetActive(false);
                    seeMenu = false;
                }
                else {
                    MemuGroup.SetActive(true);
                    seeMenu = true;
                }
                
            }

        }
    }
}
