﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.Model
{
    /// <summary>
    /// Collection of DataRow objects
    /// </summary>
    public partial class DataRowCollection : ProvisioningTemplateCollection<DataRow>
    {
        /// <summary>
        /// Constructor for DataRowCollection class
        /// </summary>
        /// <param name="parentTemplate">Parent provisioning template</param>
        public DataRowCollection(ProvisioningTemplate parentTemplate) : base(parentTemplate)
        {

        }
    }
}
