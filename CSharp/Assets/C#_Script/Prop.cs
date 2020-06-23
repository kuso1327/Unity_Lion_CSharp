﻿using UnityEngine;
using System.Collections;//引用 系統 集合 API (協同程序)

namespace CSharp_Class8
{

    public class Prop : MonoBehaviour,ICanUse
    {
        public Data data;

        public void Use()
        {
            print("使用道具：" + data.name);
            //啟動協同程序
            StartCoroutine(Big());
        }

        /// <summary>
        /// 協同程序的方法：傳回類型為IEnumverator
        /// 必須傳回時間
        /// yield return new WaitForSeconds(秒數);
        /// </summary>
        /// <returns></returns>
        private IEnumerator Big()
        {
            Transform player = FindObjectOfType<Player>().transform;
            while (player.lossyScale.x<3)
            {
                player.localScale += Vector3.one * 3 * 0.1F;
                yield return new WaitForSeconds(0.05F);     

            }
            Destroy(gameObject);
        }

    }
}
