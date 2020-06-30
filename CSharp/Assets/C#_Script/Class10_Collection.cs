using System.Collections.Generic;   //List - 泛型
using System.Collections;           //ArrayList
using UnityEngine;



namespace Lilin.Class10
{
    public class Class10_Collection : MonoBehaviour
    {
        #region List,ArrayList

        //陣列：一旦固定長度就不能改變
        public int[] scores = { 100, 90, 80, 70, 60 };

        //集合：彈性
        //清單
        public List<float> hp = new List<float> { 99.9F, 88.8F, 77.7F };
        public List<float> hpresult = new List<float>();

        public ArrayList numbers = new ArrayList();

        //排序
        public List<int> count = new List<int> { 9, 100, 15, 77, 30, 999, 123 };


        private void Start()
        {
            //1.集合可以改變長度
            hp.Add(66.6f);      //清單.增加(T)
            hp.Remove(88.8F);   //清單.刪除(T)

            print("是否包含"+hp.Contains(66.6F)); //是否包含(T)

            hpresult = hp.FindAll((x) => x >= 70F); //搜尋所有(大於等於70)資料


            //ArrayList與List差異
            //ArrayList為object型別：可存放所有類型
            //List為泛型：一旦指定類型，就只能存放一種類型 List<int> - int
            //ArrayList不會顯示在屬性面板中
            numbers.Add(100);
            numbers.Add(77.7f);
            numbers.Add("123");
            numbers.Add(true);

            count.Sort();       //由小到大
            count.Reverse();    //反轉
        }
        #endregion

        #region Queue、Stack
        //佇列
        //添加資料到尾端
        //先進先出
        //例子：飲料店的隊伍
        //先來的人先點飲料
        public Queue<int> lv = new Queue<int>();
        //堆疊
        //添加資料到頂端
        //先進後出
        //例子：堆放椅子
        //後面疊的椅子可以先拿
        public Stack<int> n = new Stack<int>();

        public Queue<string> people = new Queue<string>();
        public Stack<string> box = new Stack<string>();

        private void Awake()    //物件只要在場景上，就會被喚醒一次
        {
            lv.Enqueue(10);     //添加佇列資料，將物件加入至 Queue 結尾
            lv.Enqueue(20);
            lv.Enqueue(30);

            foreach (var item in lv)
            {
                print("佇列的資料：" + item);
            }

            n.Push(10);         //添加堆疊資料，將物件插入 Stack 的頂端，
            n.Push(20);
            n.Push(30);

            foreach (var item in n)
            {
                print("堆疊的資料：" + item);
            }

            people.Enqueue("亮亮");
            people.Enqueue("50");
            people.Enqueue("KID");

            box.Push("盒子1號");       
            box.Push("盒子2號");
            box.Push("盒子3號");


        }

        private void Update()
        {
            //佇列 先進先出
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                print("排隊的第一個人："+people.Dequeue());     //Dequeue(); 移除並傳回在 Queue 頂端的物件
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                print("堆放的第一張椅子：" + box.Pop());         //Pop(); 移除並傳回在 Stack 頂端的物件
            }
        }

        #endregion

        #region 雜湊表Hashtable、字典Dictionary
        //兩個關鍵字
        //Key、Value - 關鍵字、值

        //差異：
        //雜湊表 - 物件
        //字典 - 泛型

        public Hashtable player = new Hashtable();

        public Dictionary<string, int> data = new Dictionary<string, int>();

        //物件啟動時執行事件
        private void OnEnable()
        {
            player.Add("Lv",99);
            player.Add("Hp",9999);
            player.Add("Mp",500);
            player.Add(true, true);// ???????

            //DictionaryEntry 結構 - 儲存 Key 與 Value
            foreach (DictionaryEntry item in player)
            {
                print("雜湊表資料：" + item.Key);
                print("雜湊表資料：" + item.Value);
            }

            data.Add("短刀", 30);
            data.Add("長刀", 300);
            data.Add("屠龍刀", 30000);
            //data.Add(true, true); //錯誤

            foreach (KeyValuePair<string,int> item in data)
            {
                print("字典的Key：" + item.Key);
                print("字典的Value：" + item.Value);

            }

            //用陣列或清單村取資料只能透過索引值index - 0 1 2 3 4....
            //用雜湊表或字典可以使用Key存取資料 - "屠龍刀"、"Lv"
            print("價格：" + data["屠龍刀"]);
            print("等級：" + player["Lv"]);


        
        
        
        
        }

        #endregion
    }

}
