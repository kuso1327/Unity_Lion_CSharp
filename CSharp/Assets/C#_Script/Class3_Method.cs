using UnityEngine;

public class Class3_Method : MonoBehaviour
{
    public Class3_Person person1;
    public Class3_Person person2;

    private void Start()
    {
        //呼叫person1方法 Talk
        //欄位空值會產生錯誤
        person1.Talk();
        person2.Talk();
        //傳回方法可以直接當作傳回練習來用
        print("屁孩BMI：" + person1.BMI());
        print("警察杯杯BMI：" + person2.BMI());

        person1.Walk89("8+9走路法，","來輸贏阿!!");
        person2.Walk20();

        //使用有參數的方法必須填入對應的引數
        person1.Walk(99,sound:"wryyy");
        person2.Walk(10,"撿肥皂");

        

        person1.Attack();
        person2.Attack("沙漠之鷹");

    }

}
