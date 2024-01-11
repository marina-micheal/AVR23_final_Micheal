using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;


public class RayActivator : MonoBehaviour
{

    public XRRayInteractor rayInteractor;
    public InputActionReference teleportActivate;
    
    // Start is called before the first frame update
    void Start()
    {
        rayInteractor.enabled = false;
        teleportActivate.action.started += ShowTeleportRay;
        teleportActivate.action.canceled += HideTeleportRay;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        teleportActivate.action.started -= ShowTeleportRay;
        teleportActivate.action.canceled -= HideTeleportRay;
    }

    private void HideTeleportRay(InputAction.CallbackContext obj)
    {
        rayInteractor.enabled = false;
    }

    private void ShowTeleportRay(InputAction.CallbackContext obj)
    {
        rayInteractor.enabled = true;
    }
}
