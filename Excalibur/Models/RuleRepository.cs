using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Drawing.Text;
using System.Linq;
using System.Web;
using Excalibur.Models.BabylonDb;

namespace Excalibur.Models
{
    public class RuleRepository : IRuleRepository
    {
        private IRuleContext ruleCtx;
        public RuleRepository(IRuleContext context)
        {
            ruleCtx = context;
        }

        
    }
}