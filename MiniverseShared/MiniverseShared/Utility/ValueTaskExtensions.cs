using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MiniverseShared.Utility
{
    public static class ValueTaskExtensions
    {
        public static Action<Exception> unhandledExceptionHandler
            = e => Console.WriteLine("UnhandledException: " );

        public static void RegisterUnhandledExceptionHandler(Action<Exception> unhandledExceptionHandler)
        {
            ValueTaskExtensions.unhandledExceptionHandler = unhandledExceptionHandler;
        }
        
        public static void Forget(this ValueTask task)
        {
            var awaiter = task.GetAwaiter();
            if(awaiter.IsCompleted)
            {
                try
                {
                    awaiter.GetResult();
                }
                catch(Exception e)
                {
                    unhandledExceptionHandler(e);
                }
            }
            else
            {
                awaiter.OnCompleted(() =>
                {
                    try
                    {
                        awaiter.GetResult();
                    }
                    catch(Exception e)
                    {
                        unhandledExceptionHandler(e);
                    }
                });
            }
        }
    
        public static void Forget<T>(this ValueTask<T> task)
        {
            var awaiter = task.GetAwaiter();
            if(awaiter.IsCompleted)
            {
                try
                {
                    awaiter.GetResult();
                }
                catch(Exception e)
                {
                    unhandledExceptionHandler(e);
                }
            }
            else
            {
                awaiter.OnCompleted(() =>
                {
                    try
                    {
                        awaiter.GetResult();
                    }
                    catch(Exception e)
                    {
                        unhandledExceptionHandler(e);
                    }
                });
            }
        }
    }
}
