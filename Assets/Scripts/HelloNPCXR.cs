using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class HelloNPCXR : MonoBehaviour
{
    public GameObject uiCanvas;

    private ActionBasedController controller;
    private bool isUIVisible = false;

    void Awake()
    {
        controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("������Ʈ ����");
        if (controller.inputDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool triggerPressed) && triggerPressed)
        {
            Debug.Log("Ʈ���Ŵ� ����");
        }
    }

    private void ToggleUI()
    {
        isUIVisible = !isUIVisible;
        uiCanvas.SetActive(isUIVisible);
    }
}