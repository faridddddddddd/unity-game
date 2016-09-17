using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

	public Transform oringalParent = null;
	// Use this for initialization
	void Start () {
		
	}

	public void OnBeginDrag(PointerEventData eventData){
		Debug.Log ("OnBeginDrag");
		this.oringalParent = this.transform.parent;
		this.transform.SetParent (this.transform.parent.parent);

	}
	public void OnDrag(PointerEventData eventData){
//		Debug.Log ("OnDrag");
		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData){
		Debug.Log ("OnEndDrag");
		this.transform.SetParent (oringalParent);
	}
}
