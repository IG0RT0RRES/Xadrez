using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Xadrez
{
    public class King : Peace
    {
        public override Vector3[,] MovimentosPossiveis()
        {
            return new Vector3[,] { };
        }

        public override void Start()
        {
            gameObject.AddComponent<Rigidbody>();
        }
        public override Peace OnDownPeace()
        {
            return this;
        }
        public void OnMouseDown()
        {
            Debug.Log(OnDownPeace().ToString());
        }

        public override string ToString()
        {
            return gameObject.name;
        }
    }
}