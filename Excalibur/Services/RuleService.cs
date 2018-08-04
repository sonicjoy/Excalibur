using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Excalibur.Models;
using Excalibur.Models.BabylonDb;

namespace Excalibur.Services
{
    public class RuleService
    {
        private IRuleRepository repo;
        public RuleService(IRuleRepository repository)
        {
            repo = repository;
        }

        public IEnumerable<source_rule> GetAllRules(int systemId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<source_rule> GetSourceRules(int sourceId)
        {
            throw new NotImplementedException();
        }
    }
}