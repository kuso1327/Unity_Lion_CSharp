using UnityEngine;

public class Class5_IfSwitchLoop : MonoBehaviour
{
    
    [Header("是否開門")]
    public bool OpenDoor;
    [Header("分數")]
    public int score = 0;
    [Header("血量"),Range(0,100)]
    public float hp=100;
    [Header("道具")]
    public string prop = "紅水";

    public Season season;

    [Header("道具數量")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;
    public string test;
    public int i = 1;
    public int j = 1;

    //GameObject可存放階層面板或專案模型
    [Header("地板")]
    public GameObject cube;

    public int[] scores = { 100, 99, 88, 77, 66, 55 };


    private void CreateFloor(int length,int width)
    {
       //巢狀迴圈
       //注意初始值名稱不能相同
        for (int j = 0; j < length; j++)
        {
              for (int i = 0; i < length; i++)
               {        
                //API實例化(生成)
                //生成(物件，座標，角度)
                //Vector3三維向量(保存三個浮點數)
                //Quaternion角度
                //Quaternion.identity零角度
                //Quaternion.Euler(x,y,z)歐拉角度- 0~360度
                Instantiate(cube,new Vector3(j*2,0,i*2),Quaternion.Euler(270,0,0));
                }
        }
       
    }

    private void Awake()
    {
        #region 認識迴圈
        //使用for迴圈取得陣列資料
        for (int i = 0; i < scores.Length; i++)
        {
            print("for迴圈取得資料：" + scores[i]);
        }
        
        //foreach迴圈
        //語法：foreach (取得資料類型取得資料名稱in陣列) {執行次數為陣列數量}
        foreach (int item in scores)
        {
            print("foreach迴圈取得資料："+item);
        }

        CreateFloor(10,5);
        //while迴圈
        //while(布林值){當布林值為true執行}
        //++連續遞增1 ; --連續遞減1
        //迴圈之前評估：第一次判斷i = 1
        while(i<=10)
        {
            print("while迴圈第：" + i + "次");
            i++;
        }

        //迴圈之後評估：第一次判斷i = 2
        do
        {
            print("do迴圈第：" + 1 + "次");
            j++;
        } while (j <= 10);

        //for迴圈(初始值；條件；迭代器)
        for (int k = 1; k <= 10; k++)
        {
            print("for迴圈第：" + k + "次");
        }

        for (int l = 10; l > 0; l--)
        {
            print("for迴圈第：" + l + "次");
        }
        #endregion

        /* 
        for (int i = 0; i < 101; i++)
        {
            print("break迴圈：" + i);
            
            //如果i等於10，就打斷迴圈並執行迴圈下方的程式
            if (i == 10)break;
        }
        print("break迴圈外的程式");
        */
        /*
        for (int i = 0; i < 101; i++)
        {
            print("return迴圈：" + i);

            //如果i等於10，跳出方法外，下方程式不執行
            if (i == 10) return;
        }
        print("return迴圈外的程式");
        */
        /*
        for (int i = 0; i < 21; i++)
        {
           //執行結果：0-4 6-19迴圈外的程式
            if (i == 5) continue;
             print("continue迴圈：" + i);
        }
        print("continue迴圈外的程式");
        */
       
        for (int i = 0; i < 11; i++)
        {
            //goto標記名稱
            if (i == 5) goto Test;
            print("goto迴圈：" + i);
            
            
        }
    Test:
         print("這是標記陳述式");
        
    }

    public void Start()
    {
        

        //if判斷式
        //if(布林值){布林值=true時執行}
        if(true)
        {
            print("哈囉，我是if判斷式~");

        }
    }

    //更新事件：一秒執行約60次(60FPS)
    private void Update()
    {
        //當道具數量>=5 任務完成true      
        //三元運算子 - 布林運算式 ? 運算式A : 運算式B
        //指派、呼叫
        complete = (count >= 5) ? true : false;
        test = score >= 60 ? "及格" : score >= 40 ? "補考" : "被當";
       
        /*用if判斷式的寫法
        if(count>=5)
        {
            complete = true;
        }
        else
        {
            complete = false;
        }
        */
            
            switch(prop)
        {
            case "紅水":
                print("補HP~");
                break;
            case "藍水":
                print("補MP~");
                break;
            //default可省略
            default:
                print("你吃錯道具了~");
                break;
        }
        //switch打完 + Tab*2 ，在()內輸入season，Enter*2
        switch (season)
        {
            case Season.Spring:
                break;
            case Season.Summer:
                break;
            case Season.Fall:
                break;
            case Season.Winter:
                break;
            default:
                break;
        }
        
        //當OpenDoor為true執行{開門}
        //當OpenDoor為false執行{關門}
        //if(OpenDoor==true)
        if(OpenDoor)
        {
            print("開門~");
        }
        else
        {
            print("關門~");
        }

        //比較運算子、邏輯運算子結果為布林值
        //大於等於60及格
        //小於60被當
        //一組判斷式只會有一個執行結果
        if(score>=60)
        {
            print("及格");
        }
        else if (score>=40)
        {
            print("補考~");
        }
        else
        {
            print("被當~");
        }

        if (hp >= 70)
        {
            print("安全");
        }
        else if (hp >= 20)
        {
            print("警告");
        }
        else  
        {
            print("危險");
        }
    }
}
