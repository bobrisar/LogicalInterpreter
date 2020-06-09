using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalInterpreter
{
    public class AndExpression : Expression
    {
        Dictionary<string, bool> andExpressions = new Dictionary<string, bool>
        {
            {"0 && 0", false },
            {"0 && 1", false },
            {"1 && 0", false },
            {"1 && 1", true }
        };

        public override void Interpret(Context context)
        {
            while (context.Input.Contains("&&"))
            {
                foreach (var entry in andExpressions)
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
