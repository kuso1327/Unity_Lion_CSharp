using UnityEngine;
using UnityEngine.Events;   //引用 事件系統 API - 拖拉介面
using UnityEngine.EventSystems;

//實作介面後也要實作介面所有成員
public class Card : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler
{
    private Vector3 pos;

    public void OnBeginDrag(PointerEventData eventData)
    {
        print("開始拖拉了~");
        pos = transform.position;                   //紀錄原始座標
    }

    public void OnDrag(PointerEventData eventData)
    {
        print("拖拉中...");
        transform.position = eventData.position;    //座標 = 拖拉事件.座標
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("拖拉結束!");
        transform.position = pos;                   //回到原始座標

    }

    public void SkillEffect()
    {
        print("技能特效~");
    }
}
