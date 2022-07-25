using UnityEngine;

namespace RRRStudyProject
{
    public abstract class Unit : MonoBehaviour
    {
        //���������� ����� �������������� ������� ������
        public UnitData data;
        protected UnitMovement movement;

        public abstract void Update();
    }
}
