using UnityEngine;

public class MonsterMnager : MonoBehaviour
{


    [Header("怪物陣列0狐狸 1老鷹 2老鼠 3青蛙")]
    public GameObject[] monsters;


    /// <summary>
    /// 生成怪物
    /// </summary>
    /// <param name="index"></param>
    public void CreateMonster(int index)
    {
        Instantiate(monsters[index], new Vector3(-12, 1.3F, 0), Quaternion.identity);
    }




}
