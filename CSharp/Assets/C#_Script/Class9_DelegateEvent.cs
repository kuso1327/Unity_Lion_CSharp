﻿using UnityEngine;

public class Class9_DelegateEvent : MonoBehaviour
{
    public void AddTen(int number)
    {
        int n = number += 10;
        print("數字累加10：" + n);
    }

    public int number1 = 1;

    private void Awake()
    {
        AddTen(9);
        AddTen(number1);
    }

    public void MethodA()
    {
        print("我是方法A");
    }

    public void MethodB()
    {
        print("我是方法B");
    }
    //簽名：無傳回、無參數 的任何方法
    public void MethodC(string msg)
    {
        print("我是方法C - " + msg);
    }

    //定義委派
    //可以儲存 無傳回、無參數 的任何方法
    public delegate void DelegateTest();

    //可以儲存 無傳回、一個字串參數 的任何方法
    public delegate void DelegateTest2(string s);

    //定義委派欄位
    public DelegateTest dA;
    public DelegateTest dB;
    public DelegateTest dC;

    public DelegateTest d;
    public DelegateTest d2;

    public DelegateTest2 dC2;
    private void Start()
    {
        dA = MethodA;           //dA 欄位儲存 方法A
        dA();                   //呼叫dA

        dB = MethodB;           //dB 欄位儲存 方法B
        dB();                   //呼叫dB


        //錯誤：不同簽名無法儲存
        dC2 = MethodC;          //儲存 方法C    
        dC2("我是委派~");

        d = MethodA;            
        d += MethodB;
        d += MethodB;
        d();

  
    }


}