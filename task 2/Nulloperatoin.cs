using System;

namespace workshop2.task2
{
    internal class NullOperatoin
    {
        public void PerformNullChecks()
        {
            string? username = null;

            string checkNull = (username == null) ? "Username is not available" : username;
            Console.WriteLine("Ternary Operator: " + checkNull);

            string checkNullByNonCoalesc = username ?? "Username is not available";
            Console.WriteLine("Null Coalescing Operator: " + checkNullByNonCoalesc);

            username ??= "Rambahadur";
            Console.WriteLine("Null Coalescing Assignment: " + username);
        }
    }
}
