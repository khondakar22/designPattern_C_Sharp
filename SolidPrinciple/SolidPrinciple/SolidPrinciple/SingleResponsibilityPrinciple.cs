using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidPrinciple
{
    public class SingleResponsibilityPrinciple
    {

        private readonly List<string> _entries = new List<string>();
        private static int _count = 0;

        public int AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
            return _count; // memento
        }

        public void RemoveEntry(int index) => _entries.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, _entries);
    }

    public class Persistence
    {
        public void Save(SingleResponsibilityPrinciple journal, string filename, bool overwrite = false)
        {
            if(overwrite || !File.Exists(filename))
                File.WriteAllText(filename, journal.ToString());
        }

    }
}
