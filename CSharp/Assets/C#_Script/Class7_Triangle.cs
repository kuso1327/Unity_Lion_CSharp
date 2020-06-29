using UnityEngine;

/// <summary>
/// 三角形 繼承 形狀
/// 三角形體積需要覆寫
/// </summary>
public class Class7_Triangle : Class7_Shape
{
    /// <summary>
    /// override覆寫：覆寫父類別
    /// </summary>
    /// <returns></returns>
    public override float GetVolume()
    {
        volume = length * width * heigth / 2; //三角形體積
        return volume;
    }

    private void Start()
    {
        print(gameObject + "體積：" + GetVolume());
    }
}
