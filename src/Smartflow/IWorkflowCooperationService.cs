﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartflow
{
    public interface IWorkflowCooperationService : IWorkflowQuery<List<WorkflowCooperation>, string>, IWorkflowPersistent<WorkflowCooperation>
    {
        void Delete(string instanceID, string nodeID);
    }
}
