using UnityEngine;

namespace Lilin.Class9
{

    //訂閱事件
    public class Class9_Mom : MonoBehaviour
    {
        public Class9_Boy boy;

        private void Start()
        {
            //訂閱事件
            boy.onNoMoney += GiveMoney;
        }

        //實作事件
        private void GiveMoney()
        {
            print("這麼快就花完啦!!!!!");
            boy.money += 1000;
        }
    }

}
