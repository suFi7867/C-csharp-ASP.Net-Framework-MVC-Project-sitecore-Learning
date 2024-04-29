using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Repository
{
    internal interface IDbInitializer
    {
        void Initialize();
    }
}

// default roles for the project ex. User , Admin , Customer etc