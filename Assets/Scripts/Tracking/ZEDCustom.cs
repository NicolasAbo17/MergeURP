using Nexweron.TargetRender;
using sl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZEDCustom : MonoBehaviour
{
    [SerializeField]
    private Material targetL;
    [SerializeField]
    private Material targetR;


    private ZEDManager zedManager;

    // Start is called before the first frame update
    void Start()
    {
        zedManager = GetComponent<ZEDManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        if (zedManager != null)
        {
            zedManager.OnZEDReady += ZEDReady;
            zedManager.OnZEDDisconnected += ZEDDisconnected;
        }
    }

    void ZEDReady()
    {
        if (zedManager.zedCamera != null && zedManager.zedCamera.IsCameraReady)
        {
            targetL.mainTexture = zedManager.zedCamera.CreateTextureImageType(VIEW.LEFT);
            targetR.mainTexture = zedManager.zedCamera.CreateTextureImageType(VIEW.RIGHT);
        }
        else
        {
            Debug.Log("Camera not ready or null");
        }
    }

    void ZEDDisconnected()
    {

    }
}
