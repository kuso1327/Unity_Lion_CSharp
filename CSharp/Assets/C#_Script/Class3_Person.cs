using UnityEngine;

public class Class3_Person : MonoBehaviour

    //若人暗暗的，點右下角Auto Generate做渲染
{
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;

    //定義方法：
    //修飾詞 回傳類型 方法名稱(參數){陳述式}
    //void 無傳回：當使用此方法時不會得到任何回傳資料，要傳回就不用寫void
    public void Talk()
    {
        //gameObject 套用此腳本的物件(沒加名稱，後面會有一串物件名稱)
        //gameObject套用此腳本的物件 的 名稱
        print("你好胖，我是"+gameObject);
        print("貓咪真可愛，我是" + gameObject.name);
    }

    //傳回方法：傳回類型不是void
    //使用此方法會得到傳回資料，必須使用關鍵字return
    /// <summary>
    /// 計算人的BMI
    /// </summary>
    /// <returns>計算完的BMI</returns>
    public float BMI()
    {
        //BMI公式
        float result = weight / ((height / 100) * (height / 100));
        //傳回return
        return result;

    }
   
    public void Walk20()
    {
        print(gameObject.name + "用時速20公里走路");        
    } 
    
    public void Walk89(string speed,string sound)
    {
        print(gameObject.name+"用"+speed+"走路"+"走路音效"+sound);
    }
    //參數類型：類型 名稱 指定 預設值
    //有預設值的參數稱為[選填是參數] - 可以不填，值為預設值
    //選填式參數要放在最右面
    /// <summary>
    /// 走路方法
    /// </summary>
    /// <param name="speed"></param>

    public void Walk(int speed,string skill="大法師",string sound="rerorero")
    {
        print(gameObject.name+"用時速"+speed+"公里"+skill);
        print("走路音效："+sound);
        print("走路方法："+skill);
    }

    //攻擊方法：徒手攻擊
    public void AttackWithHand()
    { }
    //攻擊方法：拿武器攻擊，音效
    public void AttackWithweapon()
    { }

    //多載Overload
    //1.相同名稱的方法
    //2.參數數量不同 或者 參數類型不同
    /// <summary>
    /// 徒手攻擊
    /// </summary>
    public void Attack()
    {
        print(gameObject.name + "徒手攻擊!!!");
        print("ofu-");
    }
    /// <summary>
    /// 使用武器攻擊
    /// </summary>
    /// <param name="weapon"></param>
    public void Attack(string weapon)
    {
        print(gameObject.name + "用武器" + weapon + "攻擊!!!");
        print("BangBangBang!!!");

    }
    
    //讓Unity按鈕Button使用方法條件：
    //1.修飾詞為公開public
    //2.參數數量小於等於1
    /// <summary>
    /// 技能
    /// </summary>
    public void Skill()
    {
        print(gameObject.name + "施放技能");

    }
    //新增物件UI_Canvasc畫布，更改縮放模式
    //建立UI按鈕，OnClick新增屁孩，更改模式至Person，選Skill
    //EventSystem不可刪

   
}


