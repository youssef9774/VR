using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAlpha : MonoBehaviour
{
    public Slider mainSlider;
    public GameObject currentGameObject;
    private Material currentMat;
    private float alpha;

    void Start()
    {
            currentGameObject = gameObject;
            currentMat = currentGameObject.GetComponent<Renderer>().material;
            mainSlider.value = currentMat.color.a;    
    }

    // Update is called once per frame
    public void UpdateAlpha()
    {
        Color oldColor = currentMat.color;
        alpha = mainSlider.value;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alpha);
        currentMat.SetColor("_Color", newColor);
    }
}
