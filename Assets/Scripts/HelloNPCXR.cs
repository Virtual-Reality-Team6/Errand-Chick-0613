using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class HelloNPCXR : MonoBehaviour
{
    public GameObject uiCanvas;

    private XRController controller;
    private bool isUIVisible = false;

    void Start()
    {
        controller = GetComponent<XRController>();
        uiCanvas.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        // Ʈ���� ��ư�� ������ �� ó��
        if (controller.inputDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool triggerPressed) && triggerPressed)
        {
            // ���� ����ĳ��Ʈ�� ����Ű�� ��ü ��������
            RaycastHit hit;
            if (Physics.Raycast(controller.transform.position, controller.transform.forward, out hit))
            {
                if (hit.collider.CompareTag("HelloNPC"))
                {
                    // HelloNPC ������Ʈ�� ����Ű�� Ʈ���� ��ư�� ������ �� UI ���
                    ToggleUI();
                }
            }
        }
    }

    private void ToggleUI()
    {
        isUIVisible = !isUIVisible;
        uiCanvas.SetActive(isUIVisible);
    }
}