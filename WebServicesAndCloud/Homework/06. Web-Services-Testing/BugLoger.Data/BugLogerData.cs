﻿namespace BugLogger.Data
{
    using System;
    using System.Collections.Generic;

    using BugLogger.Data.Repositories;
    using BugLogger.Models;

    public class BugLogerData : IBugLoggerData
    {
        private IBugLoggerDBContext context;
        private IDictionary<Type, object> repositories;

        public BugLogerData(IBugLoggerDBContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public BugLogerData()
            : this(new BugLoggerDBContext())
        {
        }

        public Repositories.IGenericRepository<Bug> Bugs
        {
            get
            {
                return this.GetRepository<Bug>();
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}
