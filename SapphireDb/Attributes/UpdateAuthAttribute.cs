﻿using System;

namespace SapphireDb.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    public class UpdateAuthAttribute : AuthAttributeBase
    {
        public UpdateAuthAttribute(string policies = null, string functionName = null) : base(policies, functionName)
        {
        }
    }
}
