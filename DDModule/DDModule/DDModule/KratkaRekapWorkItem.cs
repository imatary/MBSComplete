﻿
using Deklarit.Practices.CompositeUI;
using Deklarit.Practices.CompositeUI.WorkItems;
using System;


namespace DDModule.DDModule
{

    public class KratkaRekapWorkItem : MdiWorkItemBase
    {
        private string m_izvjestaj;
        private string m_opisobracuna;

        public KratkaRekapWorkItem() : base("KratkaRekapWorkItem", new KratkaRekap())
        {
            UICommandDefinition uiCommandDefinition = new UICommandDefinition("Izbornik") {
                Text = "Izbornik",
                Site = "MainShellPanel",
                IsCategory = true
            };
            this.UICommandDefinitionContainer.Add(uiCommandDefinition);
            UICommandDefinition definition = new UICommandDefinition("IspisiCommand") {
                Text = "Ispiši",
                Site = "MainShellPanel.Izbornik",
                Image = ImageResourcesNew.printer
            };
            this.UICommandDefinitionContainer.Add(definition);
            UICommandDefinition definition3 = new UICommandDefinition("IzlazCommand") {
                Text = "Izlaz",
                Site = "MainShellPanel.Izbornik",
                Image = ImageResourcesNew.cancel
            };
            this.UICommandDefinitionContainer.Add(definition3);
            UICommandDefinition definition2 = new UICommandDefinition("KontirajCommand") {
                Text = "Kontiraj DD u GK",
                Site = "MainShellPanel.Izbornik",
                Image = ImageResourcesNew.report
            };
            this.UICommandDefinitionContainer.Add(definition2);
        }

        public string Obracun
        {
            get
            {
                return this.m_izvjestaj;
            }
            set
            {
                this.m_izvjestaj = value;
            }
        }

        public string opisobracuna
        {
            get
            {
                return this.m_opisobracuna;
            }
            set
            {
                this.m_opisobracuna = value;
            }
        }
    }
}

