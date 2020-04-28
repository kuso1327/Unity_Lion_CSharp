using UnityEngine;

public class Class2_Operater : MonoBehaviour
{
    //也可以把型態從float換成int 
    public float a = 10;
    public float b = 3;

    public string c = "7";
    public int d = 3;

    public int e = 99;
    public int f = 9;

    public bool g = true;
    public bool h = false;

    public int key;
    public int result;

    public int hp = 100;
    //事件：開始事件 - 播放遊戲時執行一次
    private void Start()
    { 
        #region 數學運算子
        //數學運算子：加減乘除 + - * / %
        //腳本要掛在物件上才能執行
        print(a + b);   //13    
        print(a - b);   //7
        print(a * b);   //30
        print(a / b);   //3.333333
        print(a % b);   //兩個數值相除剩下的值 1

        //加法：串接字串與其他資料 - 其結果為字串
        print("分數:" + 99.9F);
        //將字串與數值串接在一起，是不會運算的 - 其結果為字串
        print(c + d);
        #endregion

        #region 比較運算子
        //比較運算子，結果為布林值 - 成立時true，不成立時false
        //大於、小於、大於等於、小於等於、等於、不等於
        //>     <       >=      <=      ==     !=
        print(e > f);  //t
        print(e < f);  //f
        print(e >= f); //t
        print(e <= f); //f
        print(e == f); //f
        print(e != f); //t
        #endregion
        
        #region 邏輯運算子
        //邏輯運算子：結果為布林值 - 比較兩個布林值
        //並且 && 只要有一個結果為flase，結果為false
        print("並且：" + (g && h));
        //或者||只要有一個true結果為true - |打法為Shift+鎮

        print(true && true);   //t
        print(true && false);  //f
        print(false && true);  //f
        print(false && false); //f

        print(true || true);   //t
        print(true || false);  //t
        print(false || true);  //t
        print(false || false); //f

        print(g || h); //t
      
        //顛倒運算子：!加在布林值前 - 將布林值改為顛倒的結果
        print(!true);  //f
        print(!false); //t
        #endregion

        //=指定運算子= 右邊先運算再指定給左邊
        result = 2 + 3; //result=5
        print(result);

        key = key + 1;
        print("鑰匙:"+key);//輸出為1 數量為1 

        //後置遞增++ :先輸出再遞增，輸出為1 數量為2
        print("鑰匙數量:" +key++);
        //前置遞增++ ：先遞增再輸出，輸出為3 數量為3
        print("鑰匙數量:" + ++key);

        //指派運算子：+= -= *= /= %=
        
        //hp=hp+20;
        hp += 20;
        print("血量" + hp); //120
        //hp=hp-20;
        hp -= 20;
        print("血量" + hp);//100
        //hp=hp*20
        hp *= 20;
        print("血量" + hp);//2000
        //hp=hp/20
        hp /= 20;
        print("血量" + hp);//100
        //hp=hp%20
        hp %= 20;
        print("血量" + hp);//0

        //運算都是連著的，若不想要連著，需重新定義值
        print( a = a + 1); //11
        print( a = a + 2); //13
        
        a = 10;
        print(a = a + 1); //11
        a = 10;
        print(a = a + 2); //12
    }

}
