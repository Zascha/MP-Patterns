using System.Collections;
using System.Collections.Generic;

namespace BehavioralPatterns.Iterator
{
    public class Users : IEnumerable<User>, IEnumerator<User>
    {
        private int _position = -1;
        public List<User> UserList;
        public User Current => UserList[_position];
        object IEnumerator.Current => Current;

        public Users()
        {
            UserList = new List<User>();
        }

        public bool MoveNext()
        {
            if (++_position < UserList.Count &&
                UserList.Count != 0)
            {
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            _position = 0;
        }

        public IEnumerator<User> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            UserList.Clear();
        }
    }
}
