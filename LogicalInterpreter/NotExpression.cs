using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalInterpreter
{
    public class NotExpression : Expression
    {
        Dictionary<string, bool> notExpressions = new Dictionary<string, bool>
        {
            {"!0", true },
            {"!1", false }
        };

        public override void Interpret(Context context)
        {
            foreach (var entry in notExpressions)
            {
                if (context.Input.Contains(entry.Key))
                {
                    context.Input = context.Input.Replace(entry.Key, Convert.ToInt32(entry.Value).ToString());
                }
            }
        }
    }
}
