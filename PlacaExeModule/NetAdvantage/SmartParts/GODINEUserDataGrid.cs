﻿namespace NetAdvantage.SmartParts
{
    using Deklarit.Controls;
    using Infragistics.Win;
    using Infragistics.Win.UltraWinGrid;
    using Microsoft.Practices.CompositeUI.SmartParts;
    using NetAdvantage.Controls;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class GODINEUserDataGrid : UserControl, ISmartPartInfo
    {
        private IContainer components = null;
        private string m_Description = "Work with GODINE";
        private bool m_FillAtStartup = true;
        private string m_Title = "Work with GODINE";
        private GODINEDataGrid userControlDataGridGODINE;

        public GODINEUserDataGrid()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void Fill()
        {
            this.DataGrid.Fill();
        }

        private void GODINEUserDataGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
        }

        private void GODINEUserDataGrid_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode && this.FillAtStartup)
            {
                this.DataGrid.Fill();
            }
        }

        private void InitializeComponent()
        {
            this.userControlDataGridGODINE = new GODINEDataGrid();
            ((ISupportInitialize) this.userControlDataGridGODINE).BeginInit();
            UltraGridBand band = new UltraGridBand("GODINE", -1);
            UltraGridColumn column2 = new UltraGridColumn("IDGODINE");
            UltraGridColumn column = new UltraGridColumn("GODINEAKTIVNA");
            this.SuspendLayout();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            column2.CellActivation = Activation.NoEdit;
            column2.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate;
            column2.Header.Caption = StringResources.GODINEIDGODINEDescription;
            column2.Width = 0x3a;
            appearance2.TextHAlign = HAlign.Right;
            column2.MaskInput = "{LOC}-nnnn";
            column2.PromptChar = ' ';
            column2.Format = "";
            column2.CellAppearance = appearance2;
            Infragistics.Win.Appearance appearance = new Infragistics.Win.Appearance();
            column.CellActivation = Activation.NoEdit;
            column.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate;
            column.Header.Caption = StringResources.GODINEGODINEAKTIVNADescription;
            column.Width = 0x41;
            column.Format = "";
            column.CellAppearance = appearance;
            band.Columns.Add(column2);
            column2.Header.VisiblePosition = 0;
            band.Columns.Add(column);
            column.Header.VisiblePosition = 1;
            this.userControlDataGridGODINE.Visible = true;
            System.Drawing.Point point = new System.Drawing.Point(0, 0);
            this.userControlDataGridGODINE.Location = point;
            this.userControlDataGridGODINE.Name = "userControlDataGridGODINE";
            this.userControlDataGridGODINE.Tag = "GODINE";
            Size size = new System.Drawing.Size(0x200, 0x144);
            this.userControlDataGridGODINE.Size = size;
            this.userControlDataGridGODINE.DisplayLayout.BorderStyle = UIElementBorderStyle.None;
            this.userControlDataGridGODINE.Dock = DockStyle.Fill;
            this.userControlDataGridGODINE.FillAtStartup = false;
            this.userControlDataGridGODINE.DisplayLayout.Appearance.TextHAlign = HAlign.Left;
            this.userControlDataGridGODINE.InitializeRow += new InitializeRowEventHandler(this.GODINEUserDataGrid_InitializeRow);
            this.userControlDataGridGODINE.DisplayLayout.BandsSerializer.Add(band);
            this.Controls.AddRange(new Control[] { this.userControlDataGridGODINE });
            this.Name = "GODINEUserDataGrid";
            size = new System.Drawing.Size(0x200, 0x144);
            this.Size = size;
            this.Load += new EventHandler(this.GODINEUserDataGrid_Load);
            ((ISupportInitialize) this.userControlDataGridGODINE).EndInit();
            this.ResumeLayout(false);
        }

        private DataRow CurrentDataRow
        {
            get
            {
                if (this.DataGrid.CurrentRowIndex == -1)
                {
                    return null;
                }
                return this.DataView[this.DataGrid.CurrentRowIndex].Row;
            }
        }

        [Browsable(false)]
        public virtual GODINEDataGrid DataGrid
        {
            get
            {
                return this.userControlDataGridGODINE;
            }
            set
            {
                this.userControlDataGridGODINE = value;
            }
        }

        [Category("Deklarit Work With "), Browsable(false)]
        public virtual System.Data.DataView DataView
        {
            get
            {
                return this.DataGrid.DataView;
            }
        }

        public string Description
        {
            get
            {
                return this.m_Description;
            }
            set
            {
                this.m_Description = value;
            }
        }

        [Category("Deklarit Work With "), DefaultValue(true), Description("True= Fill at Startup. False= Not Fill")]
        public virtual bool FillAtStartup
        {
            get
            {
                return this.m_FillAtStartup;
            }
            set
            {
                this.m_FillAtStartup = value;
            }
        }

        [DefaultValue(true), Category("Deklarit Work With ")]
        public virtual bool FillByPage
        {
            get
            {
                return this.DataGrid.FillByPage;
            }
            set
            {
                this.DataGrid.FillByPage = value;
            }
        }

        [DefaultValue("Fill"), TypeConverter(typeof(DeklaritDataGrid.FillMethodsConverter)), Category("Deklarit Work With ")]
        public virtual string FillMethod
        {
            get
            {
                return this.DataGrid.FillMethod;
            }
            set
            {
                this.DataGrid.FillMethod = value;
            }
        }

        string Microsoft.Practices.CompositeUI.SmartParts.ISmartPartInfo.Description
        {
            get
            {
                return this.m_Description;
            }
            set
            {
                this.m_Description = value;
            }
        }

        string Microsoft.Practices.CompositeUI.SmartParts.ISmartPartInfo.Title
        {
            get
            {
                return this.m_Title;
            }
            set
            {
                this.m_Title = value;
            }
        }

        [Category("Deklarit Work With "), DefaultValue(60)]
        public virtual int PageSize
        {
            get
            {
                return this.DataGrid.PageSize;
            }
            set
            {
                this.DataGrid.PageSize = value;
            }
        }

        public string Title
        {
            get
            {
                return this.m_Title;
            }
            set
            {
                this.m_Title = value;
            }
        }
    }
}

