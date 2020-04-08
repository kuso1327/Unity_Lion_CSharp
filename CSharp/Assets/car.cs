using UnityEngine;

//註解：用來說明紀錄等..只會在此腳本內看到
//摘要summary：描述此內容，會在其他腳本內看到-提高維護性與擴充性(可讀性)
//新增的 C# 放在專案內為藍圖
//放在場景物件上為實體物件
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
    //修飾詞 資料類型 欄位名稱  (指定值，結束要分號;)
    //數字可以放中間、後面，但不可放前面，想要將字分開用_，不要用空格

    //修飾詞
    //公開public：允許其他類別存取，顯示在屬性面板(Inspecter)上
    //私人private(預設)：不允許、不顯示

    //預設值
    //int、float為0
    //string為""
    //bool為false
    //欄位屬性(Attribute)：Unity 提供用於輔助欄位的功能
    //語法：[屬性名稱(值)]
    //標題[Header("字串")]
    //提示[Tooltip("字串")]
    //範圍[Range(最小值，最大值)]-僅限於數值類型的資料 int、float
    
    /// <summary>
    ///汽車的cc數 
    /// </summary> 
    [Header("CC數"),Tooltip("這台車的CC數")]
    [Range(500,5000)]
    public int cc = 2000;
    /// <summary>
    /// 汽車重量
    /// </summary>
    [Header("重量")]
    [Tooltip("汽車的重量噸位數"),Range(50,350)]
    public float weight = 100.9f;
    /// <summary>
    /// 品牌
    /// </summary>
    [Header("品牌")]
    [Tooltip("汽車的品牌")]
    public string brand = "BMW";
    /// <summary>
    /// 是否煞車
    /// </summary>
    [Header("煞車"),Tooltip("用來儲存車子是否為煞車狀態")]
    public bool brake = false;

}
