﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public abstract class Company
    {
        protected string name;

        public Company(string name)
        {
            this.name = name;
        }

        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        public abstract void LineOfDuty();
    }
}
