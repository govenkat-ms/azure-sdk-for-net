// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The runbook property associated with the entity.
    /// </summary>
    public partial class RunbookAssociationProperty
    {
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the name of the runbook.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RunbookAssociationProperty class.
        /// </summary>
        public RunbookAssociationProperty()
        {
        }
    }
}
