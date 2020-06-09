using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalInterpreter
{
    public class OrExpression : Expression
    {
        Dictionary<string, bool> orExporessions = new Dictionary<string, bool>
        {
            {"0 || 0", false },
            {"0 || 1", true },
            {"1 || 0", true },
            {"1 || 1", true }
        };

        public override void Interpret(Context context)
        {
            while (context.Input.Contains("||"))
            {
                foreach (var entry in orExporessions)
                {
                    if (context.Input.Contains(entry.Key))
                    {
                        context.Input = context.Input.Replace(entry.Key, Convert.ToInt32(entry.Value).ToString());
                    }
                }
            }
        }
    }
}
