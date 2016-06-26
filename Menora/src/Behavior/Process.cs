using System;
using System.Collections.Generic;
using System.Linq;

namespace Menora.Behavior
{
    static class Process
    {
        public static IEnumerable<string> GetProcesses()
        {
            return System.Diagnostics.Process.GetProcesses().Select(p => p.ProcessName);
        }

        public static Rule GetRule(IDictionary<string, Rule> rules, IEnumerable<string> processes)
        {
            Rule candidate;
            Rule result;

            // Do not fetch process list if there is nothing to exclude
            if (rules.Count == 0)
                return Rule.Apply;

            // Search for behavior matching of currently running processes
            result = Rule.Apply;

            foreach (var process in processes)
            {
                if (rules.TryGetValue(process, out candidate) && candidate > result)
                    result = candidate;
            }

            return result;
        }
    }
}
