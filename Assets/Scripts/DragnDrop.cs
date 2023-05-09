using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragnDrop : MonoBehaviour, IDragHandler, IEndDragHandler {

	private RectTransform transformComponent;
	public Canvas canva;
	void Start()
	{
		transformComponent = GetComponent<RectTransform>();
	}
		

	public void OnDrag(PointerEventData eventData)
	{
		
		transformComponent.anchoredPosition += eventData.delta / canva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		
	}
}
