using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalInterpreter
{
    public class ConvertExpression : Expression
    {
        Dictionary<string, bool> boolExporessions = new Dictionary<string, bool>
        {
            {"0", false },
            {"1", true }
        };

        public override void Interpret(Context context)
        {
            foreach (var entry in boolExporessions)
            {
                if (context.Input.Contains(entry.Key))
                {
                    context.Output = entry.Value;
                }
            }
        }
    }
}
