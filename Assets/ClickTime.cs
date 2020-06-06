using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickTime : MonoBehaviour
{
    Corountine startedCoroutine;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void PointerEnter()
    {
        //eventTrigger.OnPointerClick(new PointerEventData(EventSystem.current));
        startedCorountine= StartCorountine(CountByClick());

    }

    public void PointerExit(){
        StopCorountine(startedCorountine);
    }

    IEnumerator CountByClick(){
        yield return new WaitForSeconds(3f);
        ExecuteEvents.Execute<IPointerClickHandler>(this.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler); 
    }
}
