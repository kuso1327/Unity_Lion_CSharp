using UnityEngine;

//註解：用來說明紀錄等..只會在此腳本內看到
//摘要summary：描述此內容，會在其他腳本內看到-提高維護性與擴充性
/// <summary>
/// 定義汽車物件
/// </summary>

public class car : MonoBehaviour
{
    //認識第一個成員：欄位field-儲存物件資料
    //cc數    -2000       - 整數int
    //重量    -100.9      -浮點數 float(有小數點，其後要加f)
    //品牌    -bmw        -字串string
    //剎車    -是否開啟   -布林值bool  -true、false (是否，二分法)

    //定義欄位語法
    //資料類型 欄位名稱  (指定值，結束要分號;)
    //數字可以放中間、後面，但不可放前面，想要將字分開用_，不要用空格
    //預設值
    //int、float為0
    //string為""
    //bool為false

    int cc = 2000;
    float weight = 100.9f;
    string brand = "BMW";
    bool brake = false;

}
