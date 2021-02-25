using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    //public UnityEngine.GameObject downloadedObject;
    private GameObject downloaded;
    private GameObject galIce;
    private bool gal = true;
    //public UnityEngine.GameObject galObject;
    // Start is called before the first frame update
    void Start()
    {
        var comp = GetComponentsInChildren(typeof(Transform));
        foreach(var c in comp)
        {
            if(c.gameObject.name == "DownloadedBanana")
            {
                downloaded = c.gameObject;
                downloaded.SetActive(false);
            }
            else if(c.gameObject.name == "GalIce")
            {
                galIce = c.gameObject;
            }
        }
    }
    void FixedUpdate()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void switchButtonPushed()
    {
        gal = !gal;
        galIce.SetActive(gal);
        downloaded.SetActive(!gal);
    }
}
