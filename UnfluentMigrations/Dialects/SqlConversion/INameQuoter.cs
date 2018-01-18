using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Dialects.SqlConversion
{
    public interface INameQuoter
    {
        string Quote(ObjectName name);
        string Quote(SubObjectName name);
    }

    class NameQuoter : INameQuoter
    {
        private readonly string _beginQuote;
        private readonly string _endQuote;

        public NameQuoter(): this("\"", "\"") { }
        public NameQuoter(string beginQuote, string endQuote)
        {
            _beginQuote = beginQuote;
            _endQuote = endQuote;
        }

        protected string Quote(string part)
        {
            part = part.Replace(_beginQuote, _beginQuote + _beginQuote);

            if (_beginQuote != _endQuote)
            {
                part = part.Replace(_endQuote, _endQuote + _endQuote);
            }
            
            return _beginQuote + part + _endQuote;
        }
        public string Quote(ObjectName name)
        {
            var quote = QuoteParts(new[] {name.Catalog, name.Schema, name.Name});
            return quote;
        }

        protected string QuoteParts(string[] nameParts)
        {
            var parts = nameParts
                .Where(x => !String.IsNullOrEmpty(x))
                .Select(Quote);
            var quote = String.Join(".", parts);
            return quote;
        }

        public string Quote(SubObjectName name)
        {
            var quote = QuoteParts(new[] {name.Catalog, name.Schema, name.ParentName, name.Name});
            return quote;
        }
    }
}
