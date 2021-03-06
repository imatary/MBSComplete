﻿namespace NetAdvantage.Controllers
{
    using Deklarit.Practices.CompositeUI.Controllers;
    using Microsoft.VisualBasic.CompilerServices;
    using Placa;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using NetAdvantage.SmartParts;
    using NetAdvantage.WorkItems;

    public class VIRMANIWorkWithController : WorkWithControllerBase<VIRMANIWorkItem, VIRMANIDataSet>
    {
        public VIRMANIDataSet.VIRMANIRow KeysRow;

        public override void Fill(DataSet dataSet, IDictionary<string, object> row)
        {
            DataAdapterFactory.GetVIRMANIDataAdapter().Fill((VIRMANIDataSet) dataSet, Conversions.ToInteger(row["IDVIRMAN"]));
        }
    }
}

