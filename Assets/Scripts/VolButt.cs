using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VolButt : MonoBehaviour
{
    [SerializeField] Sprite mutedImg;
    [SerializeField] Sprite notMutedImg;

    Image visibleImg;

    bool muted;

    // Start is called before the first frame update
    void Start()
    {
        visibleImg = GetComponent<Image>();
        muted = false;

        if(mutedImg == null)
        {
            Debug.Log("Need Muted Image");
        }
        if(notMutedImg == null)
        {
            Debug.Log("Need Not Muted Image");
        }
    }

    public void ButtonWork()
    {

        Debug.Log("Mouse Clicked");
        if (muted == true)
        {
            Debug.Log("Unmute");
            visibleImg.sprite = notMutedImg;
            muted = false;
        }
        else if (muted == false)
        {
            Debug.Log("Mute");
            visibleImg.sprite = mutedImg;
            muted = true;
        }

    }
}
