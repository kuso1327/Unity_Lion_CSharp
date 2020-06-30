using UnityEngine;

namespace Lilin.Class9
{
    public class Class9_Dad : MonoBehaviour
    {
        public Class9_Boy boy;

        private void Start()
        {
            //訂閱者可以決定事件引發後執行的方法數量與內容
            boy.onNoMoney += HitBoy;
            boy.onNoMoney += GiveMoney;
        }
    
        private void HitBoy()
        {
            print("死小孩，欠揍喔!");
        }
        
        private void GiveMoney()
        {
            boy.money += 10;
            print("給你十塊喇 =3=");
        }
    
    
    
    
    
    }

}
