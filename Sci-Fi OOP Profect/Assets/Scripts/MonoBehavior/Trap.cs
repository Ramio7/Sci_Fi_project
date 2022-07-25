using UnityEngine;

namespace RRRStudyProject
{
    public abstract class Trap : MonoBehaviour
    {
        public TrapData data;

        public abstract void OnTriggerEnter(Collider other);
    }
}