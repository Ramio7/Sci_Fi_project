using UnityEngine;

namespace RRRStudyProject
{
    public class MainGame : MonoBehaviour
    {
        public ListExecuteObject interactiveObjects;

        void Awake()
        {
            interactiveObjects = new ListExecuteObject();
        }

        void Update()
        {
            for (int i = 0; i < interactiveObjects.Length; i++)
            {
                if (interactiveObjects[i] == null)
                {
                    continue;
                }

                interactiveObjects[i].Update();
            }
        }
    }
}