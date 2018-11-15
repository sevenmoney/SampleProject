﻿using System;
using System.Threading.Tasks;
using Abp.TestBase;
using SampleProject.EntityFrameworkCore;
using SampleProject.Tests.TestDatas;

namespace SampleProject.Tests
{
    public class SampleProjectTestBase : AbpIntegratedTestBase<SampleProjectTestModule>
    {
        public SampleProjectTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<SampleProjectDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<SampleProjectDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<SampleProjectDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<SampleProjectDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<SampleProjectDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<SampleProjectDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<SampleProjectDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<SampleProjectDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
