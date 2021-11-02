using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticInteractor : MonoBehaviour
{
    public HapticPlugin hapticPlugin;
    private InteractableChangeColor hoveredObject;
    private bool previousSecondaryButtonStatus;
    [DisplayOnlyAttribute] public bool secondButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        hapticPlugin = GameObject.Find("HapticDevice").GetComponent<HapticPlugin>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        InteractableChangeColor touchingObject = collision.gameObject.GetComponentInParent<InteractableChangeColor>();
        if (touchingObject != null)
        {
            hoveredObject = touchingObject;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        hoveredObject = null;
    }

    // Update is called once per frame
        void Update()
    {
        secondButtonPressed = hapticPlugin.Buttons[1] == 1;
        if (secondButtonPressed && !previousSecondaryButtonStatus)
        {
            if (hoveredObject != null)
            {
                hoveredObject.OnSecondaryInteractionStart(this);
            }
        }
        if (!secondButtonPressed && previousSecondaryButtonStatus)
        {
            if (hoveredObject != null)
            {
                hoveredObject = null;
            }
        }
        previousSecondaryButtonStatus = secondButtonPressed;

    }
}
