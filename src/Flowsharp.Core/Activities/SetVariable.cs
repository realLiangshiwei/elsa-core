﻿using Flowsharp.Expressions;
using Flowsharp.Models;

namespace Flowsharp.Activities
{
    public class SetVariable : Activity
    {
        public string VariableName { get; set; }
        public WorkflowExpression<object> ValueExpression { get; set; }
    }
}