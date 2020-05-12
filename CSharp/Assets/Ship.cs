using UnityEngine;

public class Ship : MonoBehaviour
{
    //公開欄位：給任何人存取
    //從其他類別取得或存放資料
    public float speed = 20;

    //私人欄位：僅限於此類別存取
    //從其他類別無法存取或存放資料
    private float weight = 50;

    //問題：
    //假設需要取得但是不能修改 - 屬性(權限)
    //屬性語法
    //修飾詞 類型 名稱 {存取權限}
    //get 可以取得
    //ste可以存放
    //屬性不會顯示在屬性面板上(ODIN)-UnityEditor
    //讀寫權限屬性
    public float length { get; set; }


    //企劃：寬度固定30不變
    //封裝欄位：
    //1.私人欄位
    //2.唯讀屬性(return私人欄位)
    private float _width = 30;
    //唯讀屬性：不能設定值
    public float width { get { return _width; } }

    private float _height = 10.5f;
    //=>(黏巴達Lambda)
    //C#6版以上|Unity 2017 C# 7版
    //C#改版8版
    //get => _height;等同於get { return _heigth; }
    public float Height { get => _height;}

    private float lv = 3;
    //企劃：攻擊力等於攻擊力*3
    //封裝欄位：
    //1.私人欄位
    //2.透過屬性存取(return私人欄位){私人欄位 = value}
    //value設定屬性時給予的值
    private float _atk;
    public float atk { get { return _atk; }set { _atk = value*lv; } }

    //快速完成黏巴達寫法48行與52行相同
    private float _def;
    public float def { get => _def; set => _def = value*lv; }

}
