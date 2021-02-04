using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication9.Models.Class.HRContext;

namespace WebApplication9.Models.Class.VModel
{
    public class EmpResearchVM
    {
        public List<HR_Employee> HR_Employee { get; set; }
        public List<HR_EmplyeeResearch> HR_EmplyeeResearch { get; set; }
    }

}