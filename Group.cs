﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schedule
{
    class Group : IEquatable<Group>
    {
        private long? _id;
        private string _name;
        
        public Group(long? id, string name)
        {
            _id = id;
            _name = name;
        }
        
        public long? Id => _id;
        public string Name => _name;
        
        public bool Equals(Group? other)
        {
            if (other == null)
                return false;
            return _name == other._name;
        }
        
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
