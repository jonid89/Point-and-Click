using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class ButtonController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float highlightedColorAlpha = 0.25f;
    private Button button;
    private Color originalColor;
    private Color newColor;

    private void Start()
    {
        button = GetComponent<Button>();
        originalColor = button.image.color;
        //button.colors = ChangeColorAlpha(button.colors, 0); // Set the initial alpha to 0
    }

    private void ChangeColorAlpha(float alpha)
    {
        newColor = originalColor;
        newColor.a = alpha;
        button.image.color = newColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ChangeColorAlpha(highlightedColorAlpha);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ChangeColorAlpha(0f);
    }

    public void EnableInteractable()
    {
        button.interactable = true;
    }

    public void DisableInteractable()
    {
        button.interactable = false;
    }


}
