using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableChangeColor : MonoBehaviour
{


    public MeshRenderer meshRenderer;
    private void OnCollisionEnter(Collision collision)
    {
        /*
        if (!collision.gameObject.CompareTag("HapticPen"))
            return;
        else
        {
            if (collision.gameObject.GetComponent<HapticInteractor>().secondButtonPressed)
                meshRenderer.material.color = GetRandomColor();
        }
        */
    }

    public void OnSecondaryInteractionStart(HapticInteractor hapticInteractor)
    {
        if(hapticInteractor.secondButtonPressed)
            meshRenderer.material.color = GetRandomColor();
    }

    private Color GetRandomColor()
    {
        return new Color(
        Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



}