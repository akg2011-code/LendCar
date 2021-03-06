﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LendCar.DBContext;
using LendCar.Models;

namespace LendCar.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public PersonRepository(LendCarDBContext Context)
        {
            this.Context = Context;
        }
        public LendCarDBContext Context { get; }
        public ApplicationUser Find(string id) => Context.People.SingleOrDefault(p => p.NationalId == id);
        public void Save() => Context.SaveChanges();

    }
}
