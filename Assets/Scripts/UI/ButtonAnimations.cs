using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonAnimations : MonoBehaviour,
IPointerEnterHandler,
IPointerExitHandler,
IPointerDownHandler,
IPointerUpHandler
{
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOKill();

        transform.DOScale(originalScale * 1.05f, 0.15f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOKill();

        transform.DOScale(originalScale, 0.15f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.DOKill();

        transform.DOScale(originalScale * 0.95f, 0.1f);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.DOKill();

        transform.DOScale(originalScale * 1.05f, 0.1f);
    }
    private void OnDestroy()
    {
        transform.DOKill();
    }
}