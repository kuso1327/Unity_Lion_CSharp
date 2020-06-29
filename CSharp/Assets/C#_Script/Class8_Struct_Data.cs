using UnityEngine;
[System.Serializable]//序列化：讓結構顯示在屬性面板
public struct Class8_Struct_Data
{
    public string name;
    public int coin;
    public float hp;


    //結構內不能有無參數的建構子
    /*
    public Struct_Data()
    {
        Debug.Log("空白的建構子");
    }
    */

    /// <summary>
    /// 設定所有資料：名稱、金幣、血量
    /// </summary>
    /// <param name="n">名稱</param>
    /// <param name="c">金幣</param>
    /// <param name="h">血量</param>
    public Class8_Struct_Data(string n, int c, float h)
    {
        name = n;
        coin = c;
        hp = h;
    }


}
