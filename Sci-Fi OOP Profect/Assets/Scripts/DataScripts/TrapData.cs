using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RRRStudyProject
{
    public struct TrapData
    {
        [Header("������������ ����")]
        public string name;
        public float damage;
        public float radiusOfFire;
        public bool isActive;

        [Header("��������������� ����")]
        public int trapId;
        public SVector3 trapPosition;
        public SQuaternion trapRotation;

        public TrapData(string trapName, float trapDamage, float trapRadiusOfFire)
        {
            name = trapName;
            damage = trapDamage;
            radiusOfFire = trapRadiusOfFire;
            isActive = true;

            //��������, ����������� ���������� ����� �������������� ������� ��������
            trapId = -1;
            trapPosition = new SVector3();
            trapRotation = new SQuaternion();
        }
    }
}