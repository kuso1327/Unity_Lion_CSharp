using UnityEngine;

/// <summary>
/// 形狀：基底類別
/// </summary>
public class Class7_Shape : MonoBehaviour
{
    [Header("長寬高")]
    public float length;
    public float width;
    public float heigth;

    /// <summary>
    /// 體積
    /// protect 保護：允許子類別存取禁止外部存取
    /// </summary>
    protected float volume;

    /// <summary>
    /// 取得體積
    /// virtual 虛擬：允許子類別覆寫
    /// </summary>
    /// <returns>體積</returns>
    public virtual float GetVolume()
    {
        volume = length * width * heigth;
        return volume;
    }
 

}
