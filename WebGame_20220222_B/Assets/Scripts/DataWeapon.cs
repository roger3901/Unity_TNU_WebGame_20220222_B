using UnityEngine;

namespace KID
{

    /// <summary>
    /// �Z�����
    /// 1.����t�� float
    /// 2.�����O float
    /// 3.�_�l�ƶq int
    /// 4.�̤j�ƶq int
    /// 5.����ɶ� float
    /// 6.�ͦ���m 
    /// </summary>
    // ScriptableObject �}���ƪ���
    // �@�ΡG�N�}��������ܦ������x�s�� Project �� (�X�R�P���@�ʨ�)
    // CreatAssetMenu �P ScriptableObject �f�t�ϥ�
    // �@�ΡG�b Project �إߦ��}���ƪ��󪺿��P�ɮצW��
    // menuName ���W�١AfileName �ɮצW��
    [CreateAssetMenu(menuName = "KID/Date Weapon", fileName = "Date Weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("����t��"), Range(0, 5000)]
        public float speed = 500;
        [Header("�����O"), Range(0, 10)]
        public float attack = 10;
        [Header("�_�l�ƶq"), Range(1, 10)]
        public int countstart = 1;
        [Header("�̤j�ƶq"), Range(1, 20)]
        public int countMax = 3;
        [Header("����ɶ�"), Range(0, 5)]
        public float interval = 3.5f;

        //�������[] �}�C _ ��Ƶ��c
        //�@�ΡG�x�s��h��ۦP���������
        [Header("�ͦ���m")]
        public Vector3[] v3SpawnPoint;
    }

}