﻿using UnityEngine;

public class Class8_StructInterface : MonoBehaviour
{
    //Unity 定義的結構 Struct
    public Vector3 pos;

    //使用結構
    public Direction myDire1;

    //new 新增物件，並且可以使用建構子
    public Direction myDire2 = new Direction(4);
    private void Start()
    {

        //使用結構成員
        //三維向量結構 方法成員
        pos.Set(1, 2, 3);

        //三維向量結構 欄位成員
        print("X座標：" + pos.x);

        //指定結構成員
        myDire1.direction = 1;

        //常數與靜態取得用法是一樣的 名稱.成員
        print("方向右邊的值：" +Direction.right);

        //Direction.left = 5;(錯誤：不能變更常數)

        myDire1.Set("左");
        print("方向：" + myDire1.direction);

        //透過 new新增的方向資訊
        print("第二筆方向資訊：" + myDire2.direction);
    }

    //類別一定要使用 new 新增物件
    public Class_Data c_data1=new Class_Data();
    //結構可用可不用
    public Struct_Data s_data1;


    //類別：參考型別 - 傳址
    public Class_Data c2 = new Class_Data("50", 99999, 100);
    public Class_Data c3 = new Class_Data("亮亮", 999999, 50);

    //結構:實質型別 - 傳值
    public Struct_Data s2 = new Struct_Data("50", 99999, 100);
    public Struct_Data s3 = new Struct_Data("亮亮", 999999, 50);

    private void Awake()
    {
        c_data1.name = "50大大";
        print(c_data1.name);

        s_data1.name = "KID";
        print(s_data1.name);

        c2 = c3;            //c2=c3兩筆資料地址相同
        c2.name = "50";     //修改c2等同於修改c3

        s2 = s3;            //s2 =s3兩筆資料 數值 相同
        s2.name = "50";     //修改 s2 不會修改到s3


    }





}
