using System;

namespace CreationalPatterns.Prototype
{
    [Serializable]
    public class LargeObject : Clonnable<LargeObject>
    {
        public int IntField;
        public string StringField;
    }
}
