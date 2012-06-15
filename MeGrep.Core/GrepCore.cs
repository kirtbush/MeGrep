using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MeGrep.Core
{
    public class GrepCore
    {
        public GrepCore()
        {
        }

        public List<GrepResults> RunGrep(string sPattern, string fileName)
        {
            List<GrepResults> results = new List<GrepResults>();
            string[] lines = System.IO.File.ReadAllLines(fileName);
            int lineCount = 1;

            foreach (var line in lines)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(line, sPattern))
                {
                    results.Add(new GrepResults(lineCount, sPattern, line, fileName));
                }
            }

            return results;
        }

        //command history
        
    }

    public class GrepQuery
    {
        //members
        private string _pattern;
        private string _fileName;
        public List<GrepResults> Results;

        //constructor
        public GrepQuery(string sPattern, string fileName)
        {
            _pattern = sPattern;
            _fileName = fileName;
            Results = new List<GrepResults>();
        }

        public List<GrepResults> RunQuery()
        {
            System.Console.WriteLine("Running Query");
            string[] lines = System.IO.File.ReadAllLines(_fileName);
            int lineCount = 1;

            foreach (var line in lines)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(line, _pattern))
                {
                    GrepResults result = new GrepResults(lineCount, _pattern, line, _fileName);
                    Results.Add(result);
                    System.Console.WriteLine("Query Results pattern: {0}\nline {1}: {2}", _pattern, lineCount, line);
                }
                lineCount++;
            }

            System.Console.WriteLine("Query Complete, results found<{0}>", lineCount-1);

            return Results;
        }
        //methods

    }

    public class GrepResults
    {
        //Fields
        #region Fields
        private int _lineNumber;
        private string _filename;
        private string _line;
        private string _pattern;
        #endregion

        //Properties
        #region Properties
        public int LineNumber;
        public string FileName;
        public string Line;
        public string Pattern;
        #endregion

        //Members
        #region Members
        public GrepResults(int linenumber, string pattern, string line, string filename)
        {
            _lineNumber = linenumber;
            _pattern = pattern;
            _line = line;
            _filename = filename;          
        }
        #endregion
    }
}
