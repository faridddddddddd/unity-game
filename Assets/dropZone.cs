using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class dropZone : MonoBehaviour, IDropHandler {

	public void Start(){
		Debug.Log (" hello in dropZone");
	}

	public void OnPointerEnter (PointerEventData eventData){
		Debug.Log ("OnPointerEnter");
	}
	public void OnPointerExit(PointerEventData eventData){
		Debug.Log ("OnPointerExit");
	}

	public void OnDrop(PointerEventData eventData){
		Debug.Log ( eventData.pointerDrag.name + " was dropped on " + gameObject.name);

		draggable d = eventData.pointerDrag.GetComponent<draggable> ();
		if (d != null) {
			d.oringalParent = this.transform;
		}
	}

}
