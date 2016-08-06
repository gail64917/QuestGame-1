﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGame.Domain.DBInitializers
{
    public class DBInitialization
    {
        List<IInitialization> methods;
        ApplicationDbContext context;

        public DBInitialization(ApplicationDbContext context)
        {
            this.context = context;
            this.methods = new List<IInitialization>();
        }

        public void Add(IInitialization obj)
        {
            methods.Add(obj);
        }

        public void Initialization()
        {
            foreach (var item in methods)
            {
                item.Initialization(context);
            }
        }
    }
}
