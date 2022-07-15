using UnityEngine;

namespace RRRStudyProject
{
    public class UnitMovement : IMove
    {
        private readonly GameObject _gameObjectToMove;
        private readonly float _movingSpeed;

        public UnitMovement(GameObject unitToMove, UnitData unitData)
        {
            _gameObjectToMove = unitToMove;
            _movingSpeed = unitData.speed;
        }

        public void Move(UnitCommandInput commandInput)
        {
            _gameObjectToMove.transform.position += _movingSpeed * Time.deltaTime * commandInput.moveTowards.normalized;
            _gameObjectToMove.transform.Rotate(-commandInput.lookAt.x, commandInput.lookAt.y, 0);
        }
    }
}