using UnityEngine;// 引用Unity API (函式庫：Unity屬性、功能...)

// 類別class定義一個物件
// 語法：class類別名稱
//：MonoBehaviour 可以將腳本掛在Unity物件上
//類別須放在物件上才會執行
public class Class1 : MonoBehaviour
{
    //定義類別成員
    //C#
    //1.大小寫不一樣
    //2.括號成對出現() [] {} ' ' " " < >
    [Header("汽車1號")]
    public Class1_car car1;

    [Header("汽車2號")]
    public Class1_car car2;
 
    //事件：在特定時間會已指定次數執行的方法(名稱為藍色 大小寫不同，要為大寫S)
    //開始事件：播放遊戲時執行一次-初始設定
    private void Start()
    {
        //輸出("文字訊息"，要用""包起來)
        print("hello,world！");

        //取得get
        print("汽車1號的cc數:"+car1.cc+"重量:"+car1.weight+"品牌:"+car1.brand+"煞車"+car1.brake);
        print("汽車2號的cc數:"+car2.cc+"重量:" + car2.weight + "品牌:" + car2.brand + "煞車" + car2.brake);
    
        //設定set
        car1.cc = 3000;
        car1.weight = 500.1f;
        car1.brand = "SUBARU";
        car1.brake = true;

    }
}
