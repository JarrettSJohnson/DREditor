﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterEditor
{
    [System.Serializable]
    [CreateAssetMenu(menuName = "DREditor/Characters/Student", fileName = "New Student")]
    public class Student : ScriptableObject
    {
        public Character Character;
        public StudentCard StudentCard;
    }
}
