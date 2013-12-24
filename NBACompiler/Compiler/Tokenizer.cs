using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBRTokenizer;
using Antlr4.Runtime;

namespace Compiler
{
    public class Tokenizer
    {
        //TODO: this is redundant with the Lexer class
        private Lexer _lexer;

        public Tokenizer(Lexer lexer)
        {
            _lexer = lexer;
        }

        public CommonTokenStream Tokenize(AntlrInputStream inputStream)
        {
            _lexer.SetInputStream(inputStream);
            return new CommonTokenStream(_lexer);
        }
    }
}
