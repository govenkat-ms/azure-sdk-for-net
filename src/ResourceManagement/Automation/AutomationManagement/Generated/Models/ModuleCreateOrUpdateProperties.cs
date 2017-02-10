// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the create or update module properties.
    /// </summary>
    public partial class ModuleCreateOrUpdateProperties
    {
        private ContentLink _contentLink;
        
        /// <summary>
        /// Required. Gets or sets the module content link.
        /// </summary>
        public ContentLink ContentLink
        {
            get { return this._contentLink; }
            set { this._contentLink = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ModuleCreateOrUpdateProperties
        /// class.
        /// </summary>
        public ModuleCreateOrUpdateProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ModuleCreateOrUpdateProperties
        /// class with required arguments.
        /// </summary>
        public ModuleCreateOrUpdateProperties(ContentLink contentLink)
            : this()
        {
            if (contentLink == null)
            {
                throw new ArgumentNullException("contentLink");
            }
            this.ContentLink = contentLink;
        }
    }
}
