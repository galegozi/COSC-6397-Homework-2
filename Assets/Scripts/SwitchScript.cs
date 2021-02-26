using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    //public UnityEngine.GameObject downloadedObject;
    private GameObject downloaded;
    private GameObject galIce;
    private bool gal = true;
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
                Animation anim = downloaded.GetComponent<Animation>();
                if(anim != null)
                {
                    anim.Play();
                }
            }
            else if(c.gameObject.name == "GalIce")
            {
                galIce = c.gameObject;
                Animation anim = galIce.GetComponent<Animation>();
                if (anim != null)
                {
                    Debug.Log("Animation Found!");
                    Debug.Log(anim.Play());
                }
                else
                {
                    Debug.Log("No Animation Found!");
                }
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
