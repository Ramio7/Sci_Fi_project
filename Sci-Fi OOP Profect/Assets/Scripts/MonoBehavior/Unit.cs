using UnityEngine;

namespace RRRStudyProject
{
    public abstract class Unit : MonoBehaviour
    {
        //доработать после проектирования фабрики юнитов
        public UnitData data;
        protected UnitMovement movement;

        public abstract void Update();
    }
}
