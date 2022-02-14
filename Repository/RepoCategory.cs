﻿using ArchiveModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepoCategory : ICRUD<Category>
    {
        public Category Create(Category obj)
        {
            Category entityCategory = new Category();
            using(var db = new ArchiveContext())
            {
               entityCategory = db.Categories.Add(obj).Entity;
                db.SaveChanges();
            }
            return entityCategory;
        }

        public void Delete(Category obj)
        {
            using (var db = new ArchiveContext())
            {
                db.Categories.Remove(obj);
                db.SaveChanges();
            }
        }

        public ICollection<Category> GetAll()
        {
            using (var db = new ArchiveContext())
            {
                return db.Categories.ToList();
            }
        }

        public Category Update(Category obj)
        {
            Category entityCategory = new Category();

            using (var db = new ArchiveContext())
            {
                entityCategory = db.Categories.Update(obj).Entity;
                db.SaveChanges();
            }
            return entityCategory;
        }
    }
}