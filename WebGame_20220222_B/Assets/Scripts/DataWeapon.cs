using UnityEngine;

namespace KID
{

    /// <summary>
    /// 武器資料
    /// 1.飛行速度 float
    /// 2.攻擊力 float
    /// 3.起始數量 int
    /// 4.最大數量 int
    /// 5.間格時間 float
    /// 6.生成位置 
    /// </summary>
    // ScriptableObject 腳本化物件
    // 作用：將腳本的資料變成物件儲存於 Project 內 (擴充與維護性佳)
    // CreatAssetMenu 與 ScriptableObject 搭配使用
    // 作用：在 Project 建立此腳本化物件的選單與檔案名稱
    // menuName 選單名稱，fileName 檔案名稱
    [CreateAssetMenu(menuName = "KID/Date Weapon", fileName = "Date Weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("飛行速度"), Range(0, 5000)]
        public float speed = 500;
        [Header("攻擊力"), Range(0, 10)]
        public float attack = 10;
        [Header("起始數量"), Range(1, 10)]
        public int countstart = 1;
        [Header("最大數量"), Range(1, 20)]
        public int countMax = 3;
        [Header("間格時間"), Range(0, 5)]
        public float interval = 3.5f;

        //資料類型[] 陣列 _ 資料結構
        //作用：儲存更多比相同類型的資料
        [Header("生成位置")]
        public Vector3[] v3SpawnPoint;
    }

}