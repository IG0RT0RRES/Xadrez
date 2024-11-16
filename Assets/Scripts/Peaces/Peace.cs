using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Xadrez
{
    public abstract class Peace : MonoBehaviour
    {
        [SerializeField] private Vector3 _position;
        [SerializeField] private Color _color;


        #region Properties

        public Vector3 Position
        {
            get { return _position; }
        }

        public Color Color
        {
            get { return _color; }
        }

        #endregion

        public abstract void Start();

        public abstract Vector3[,] MovimentosPossiveis();

        public abstract Peace OnDownPeace();
    }
}