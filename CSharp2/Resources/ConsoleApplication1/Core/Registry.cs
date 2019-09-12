﻿using Model;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
    public class Registry<T> : IEnumerable<T> where T: IModel
    {        
        private RegistryPivot<T> Enumerator { get; set; }

        public Registry()
        {
            Enumerator = new RegistryPivot<T>();            
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Enumerator;
        }
    }
}