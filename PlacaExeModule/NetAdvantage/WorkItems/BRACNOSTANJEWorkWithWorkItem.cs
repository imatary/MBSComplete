﻿namespace NetAdvantage.WorkItems
{
    using Deklarit.Practices.CompositeUI;
    using Deklarit.Practices.CompositeUI.WorkItems;
    using Deklarit.Resources;
    using System;
    using NetAdvantage.SmartParts;

    public class BRACNOSTANJEWorkWithWorkItem : WorkWithWorkItemBase<BRACNOSTANJEWorkWith>
    {
        public BRACNOSTANJEWorkWithWorkItem() : base("BRACNOSTANJE")
        {
            
            this.UICommandDefinitionContainer.Add(new UICommandDefinition[] { new UICommandDefinition("Tasks", Deklarit.Resources.Resources.Tasks, this.Site, true), new UICommandDefinition("View", Deklarit.Resources.Resources.toolDisplay, this.Site + ".Tasks", ImageResourcesNew.hand_property, null, "BRACNOSTANJE.Select;!BRACNOSTANJE.Update"), new UICommandDefinition("Insert", Deklarit.Resources.Resources.toolInsert, this.Site + ".Tasks", ImageResourcesNew.page_add, null, "BRACNOSTANJE.Insert"), new UICommandDefinition("Update", Deklarit.Resources.Resources.toolUpdate, this.Site + ".Tasks", ImageResourcesNew.page_edit, null, "BRACNOSTANJE.Update"), new UICommandDefinition("Delete", Deklarit.Resources.Resources.toolDelete, this.Site + ".Tasks", ImageResourcesNew.page_delete, null, "BRACNOSTANJE.Delete"), new UICommandDefinition("Copy", Deklarit.Resources.Resources.toolCopy, this.Site + ".Tasks", ImageResourcesNew.page_copy, null, "BRACNOSTANJE.Insert"), new UICommandDefinition("Refresh", Deklarit.Resources.Resources.toolRefresh, this.Site + ".Tasks", ImageResourcesNew.page_refresh, null, "BRACNOSTANJE.Select"), new UICommandDefinition("FillAll", Deklarit.Resources.Resources.toolLoadAll, this.Site + ".Tasks", ImageResourcesNew.page_save, null, "BRACNOSTANJE.Select"), new UICommandDefinition("Print", Deklarit.Resources.Resources.toolPrint, this.Site + ".Tasks", ImageResourcesNew.printer, null, "BRACNOSTANJE.Select"), new UICommandDefinition("Export", Deklarit.Resources.Resources.toolExport, this.Site, false, true, DeklaritMode.All), new UICommandDefinition("ExportExcel", Deklarit.Resources.Resources.toolExportExcel, this.Site + ".Export", ImageResourcesNew.export_excel, null, "BRACNOSTANJE.Select"), new UICommandDefinition("RADNIK", "Zaposlenici", this.Site + ".Relationships", ImageResourcesNew.group, null, "RADNIK.Select"), new UICommandDefinition("Relationships", Deklarit.Resources.Resources.toolRelations, this.Site, false, true, DeklaritMode.All) });
        }
    }
}

