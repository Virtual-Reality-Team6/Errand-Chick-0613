using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class XRControllerCommon : MonoBehaviour
{
    private ActionBasedController controller;

    public GameObject playerObject;
    private Player player;
    public bool hasCoin;

    private void Start()
    {
        controller = GetComponent<ActionBasedController>();
        player = playerObject.GetComponent<Player>();
    }

    private void Update()
    {
        if (controller != null)
        {
            Debug.Log("트리거가 눌렸다.");
            if (controller.activateAction.action.ReadValue<float>() > 0.5f)
            {
                
                RaycastHit hit;
                if (Physics.Raycast(controller.transform.position, controller.transform.forward, out hit))
                {
                    if (hit.collider.CompareTag("HelloNPC"))
                    {
                        Debug.Log("HelloNPC 인식");
                        HelloNPCVR helloNPCVR = hit.collider.GetComponent<HelloNPCVR>();
                        if (player.iscompletedStamp[helloNPCVR.interactionIndex]) helloNPCVR.CorrectAnswerChoice();
                        else helloNPCVR.StartHelloInteraction();
                    }
                    else if(hit.collider.CompareTag("BadNPC"))
                    {
                        Debug.Log("BadNPC 인식");
                        BadNPCVR badNPCVR = hit.collider.GetComponent<BadNPCVR>();
                        if (player.iscompletedStamp[badNPCVR.interactionIndex]) badNPCVR.CorrectAnswerChoice();
                        else badNPCVR.StartBadInteraction();
                    }
                    //else if (hit.collider.CompareTag("SadNPC"))
                    //{
                    //    Debug.Log("SadNPC 인식");
                    //    SadNPCVR sadNPCVR = hit.collider.GetComponent<SadNPCVR>();
                    //    if(hasCoin) sadNPCVR.StartSadInteraction();
                    //    else sadNPCVR.WrongAnswerChoice();
                    //}
                }
            }
        }
    }
}
