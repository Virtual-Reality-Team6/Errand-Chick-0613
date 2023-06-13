using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class XRControllerRight : MonoBehaviour
{
    private ActionBasedController controller;

    public GameObject MemoStampGroup;
    public bool seeMemoAndStamp;

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
                if (seeMemoAndStamp) {
                    MemoStampGroup.SetActive(false);
                    seeMemoAndStamp = false;
                }
                else
                {
                    MemoStampGroup.SetActive(true);
                    seeMemoAndStamp = true;
                }

            }
        }
    }
}
