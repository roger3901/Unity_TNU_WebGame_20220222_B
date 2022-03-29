using UnityEngine;

namespace KID
{
    /// <summary>
    /// �Z���t�ΡG
    /// 1.�]�w���a���o���Z��
    /// 2.�ͦ��Z��
    /// 3.�o�g�Z��
    /// 4.�����O�x�s
    /// </summary>

    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;

        ///<summary>
        ///�p�ɾ�
        ///</summary>
        private float timer;

        //ø�s�ϥܨƥ� ODG
        //�@�ΡG�b�s�边�����U�ΡA�����ɤ����|�X�{
        private void OnDrawGizmos()
        {
            //1.�M�w�ϥ��C��
            // color(���A��A�šA�z����) - 0 ~ 1
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            //2.ø�s�ϥ�
            //�ϥ�,ø�s�y��(�����I�A�b�|)
            //���w�}�C��ƻy�k�G�}�C��ƦW��[���ޭ�]

            //for �j��G���ƳB�z�{���϶�
            //(��l��;����;�j�鵲���|����{��)
            for(int i = 0; i < dataWeapon.v3SpawnPoint.Length; i++)
            Gizmos.DrawSphere(transform.position + dataWeapon.v3SpawnPoint[i], 0.1f);
        }

        private void Update()
        {
            SpawnWeapon();
        }

        ///<summary>
        ///�ͦ��Z��
        ///1.�p��ɶ�
        ///2.�ɶ��֭p���j�ɶ�
        ///3.�ͦ��Z��
        ///4.���w�b�ͦ���m�W
        ///5.�o�g�Z��
        ///6.�ᤩ�Z�������O
        ///</summary>
        private void SpawnWeapon()
        {
            //Time.deltaTime �@�Ӽv�檺�ɶ�
            timer += Time.deltaTime;

            //print("�g�L���ɶ��G" + timer);

            //�p�G �p�ɾ� �j�󵥩� ����ɶ� �N�ͦ� �Z��

            if (timer >= dataWeapon.interval)
            {
                print("�ͦ��Z��");
                timer = 0;
            }
        }
    }
}
