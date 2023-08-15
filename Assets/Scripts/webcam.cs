using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class webcam : MonoBehaviour
{
    [SerializeField] WebCamTexture webCamTexture;
    public string path;
    public RawImage imgDisplay;


    // Start is called before the first frame update
    void Start()
    {
        webCamTexture = GetComponent<WebCamTexture>();
        GetComponent<Renderer>().material.mainTexture = webCamTexture;
        webCamTexture.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
