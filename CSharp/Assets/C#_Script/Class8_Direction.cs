﻿using UnityEngine;

public struct Class8_Direction
{
    //結構與類別的差異1
    //結構的欄位不能給予預設值 (錯誤：public int direction = 1 ;)

    /// <summary>
    /// 方向：1前，2後，3左，4右
    /// </summary>
    public int direction ;

    //可以添加修飾詞 const 常數，就可以給予預設值
    //const 常數：不能變更值
    public const int forward = 1;
    public const int back = 2;
    public const int left = 3;
    public const int right = 4;

    /// <summary>
    /// 設定方向
    /// </summary>
    /// <param name="direction">前、後、左、右</param>
    public void Set(string direction)
    {
        switch (direction)
        {
            case "前":
                this.direction = 1;
                break;
            case "後":
                this.direction = 2;
                break;
            case "左":
                this.direction = 3;
                break;
            case "右":
                this.direction = 4;
                break;

            }
    }

    //建構子：名稱與結構相同並且沒有傳回類型的方法
    //作用：在新增物件時會自動執行此方法
    //結構與類別的差異2
    //結構與建構子需要有參數
    public Class8_Direction(int dir)
    {
        direction = dir;
    }
}
