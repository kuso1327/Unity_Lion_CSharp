using UnityEngine;
namespace Lilin.Class10
{
    public class Class10_Gernericx : MonoBehaviour
    {
        public CharacterFloat cF = new CharacterFloat(100.5F, 50.9F, 10.3F);    //角色浮點數
        public CharacterInt cI = new CharacterInt(100, 50, 15);                 //角色整數

        public Character<float> c1 = new Character<float>(99.9f, 99.9f, 9.9f);  //使用泛型：給予浮點數
        public Character<int> c2 = new Character<int>(50, 50, 50);              //使用泛型：給予整數
        public Character<long> c3 = new Character<long>(1000, 1000, 5000);      //使用泛型：給予長整數


    }

    //假設系統需要角色類別
    //1. 浮點數欄位 - 血量、經驗值、魔力、攻擊力
    //2. 整數欄位 - 血量、經驗值、魔力、攻擊力

    public class CharacterFloat
    {
        public float hp;
        public float mp;
        public float exp;
        public float atk;
        
        //建構子：跟類別名稱相同並且無傳回的方法 - 在新增物件時執行
        public CharacterFloat(float h,float m,float a)
        {
            hp = h;
            mp = m;
            atk = a;

        } 

    }

    public class CharacterInt
    {
        //多個游標：Alt+Shift+>
        public float hp;
        public float mp;
        public float exp;
        public float atk;

        //建構子：跟類別名稱相同並且無傳回的方法 - 在新增物件時執行
        public CharacterInt(float h, float m, float a)
        {
            hp = h;
            mp = m;
            atk = a;
        }
    }
    //我想多一個長整數 long

    //使用泛型T泛型
    public class Character<T>
    {
        public T hp;    //欄位的類行為泛型
        public T mp;
        public T exp;
        public T atk;
    
        public Character(T h,T m,T a)
        {
            hp = h;
            mp = m;
            atk = a;
        }
    
    }


}
