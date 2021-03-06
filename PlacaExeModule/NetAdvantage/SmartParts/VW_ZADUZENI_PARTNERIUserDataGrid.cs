﻿namespace NetAdvantage.SmartParts
{
    using Infragistics.Win;
    using Infragistics.Win.UltraWinGrid;
    using Microsoft.Practices.CompositeUI.SmartParts;
    using NetAdvantage.Controls;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class VW_ZADUZENI_PARTNERIUserDataGrid : UserControl, ISmartPartInfo
    {
        private IContainer components = null;
        private string m_Description = "Work with VW_ZADUZENI_PARTNERI";
        private bool m_FillAtStartup = true;
        private string m_Title = "Work with VW_ZADUZENI_PARTNERI";
        private VW_ZADUZENI_PARTNERIDataGrid userControlDataGridVW_ZADUZENI_PARTNERI;

        public VW_ZADUZENI_PARTNERIUserDataGrid()
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

        private void InitializeComponent()
        {
            this.userControlDataGridVW_ZADUZENI_PARTNERI = new VW_ZADUZENI_PARTNERIDataGrid();
            ((ISupportInitialize) this.userControlDataGridVW_ZADUZENI_PARTNERI).BeginInit();
            UltraGridBand band = new UltraGridBand("VW_ZADUZENI_PARTNERI", -1);
            UltraGridColumn column = new UltraGridColumn("IDPARTNER");
            this.SuspendLayout();
            Infragistics.Win.Appearance appearance = new Infragistics.Win.Appearance();
            column.CellActivation = Activation.NoEdit;
            column.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate;
            column.Header.Caption = StringResources.VW_ZADUZENI_PARTNERIIDPARTNERDescription;
            column.Width = 0x70;
            appearance.TextHAlign = HAlign.Right;
            column.MaskInput = "{LOC}-nnnnnnnnn";
            column.PromptChar = ' ';
            column.Format = "";
            column.CellAppearance = appearance;
            band.Columns.Add(column);
            column.Header.VisiblePosition = 0;
            this.userControlDataGridVW_ZADUZENI_PARTNERI.Visible = true;
            System.Drawing.Point point = new System.Drawing.Point(0, 0);
            this.userControlDataGridVW_ZADUZENI_PARTNERI.Location = point;
            this.userControlDataGridVW_ZADUZENI_PARTNERI.Name = "userControlDataGridVW_ZADUZENI_PARTNERI";
            this.userControlDataGridVW_ZADUZENI_PARTNERI.Tag = "VW_ZADUZENI_PARTNERI";
            Size size = new System.Drawing.Size(0x200, 0x144);
            this.userControlDataGridVW_ZADUZENI_PARTNERI.Size = size;
            this.userControlDataGridVW_ZADUZENI_PARTNERI.DisplayLayout.BorderStyle = UIElementBorderStyle.None;
            this.userControlDataGridVW_ZADUZENI_PARTNERI.Dock = DockStyle.Fill;
            this.userControlDataGridVW_ZADUZENI_PARTNERI.FillAtStartup = false;
            this.userControlDataGridVW_ZADUZENI_PARTNERI.DisplayLayout.Appearance.TextHAlign = HAlign.Left;
            this.userControlDataGridVW_ZADUZENI_PARTNERI.InitializeRow += new InitializeRowEventHandler(this.VW_ZADUZENI_PARTNERIUserDataGrid_InitializeRow);
            this.userControlDataGridVW_ZADUZENI_PARTNERI.DisplayLayout.BandsSerializer.Add(band);
            this.Controls.AddRange(new Control[] { this.userControlDataGridVW_ZADUZENI_PARTNERI });
            this.Name = "VW_ZADUZENI_PARTNERIUserDataGrid";
            size = new System.Drawing.Size(0x200, 0x144);
            this.Size = size;
            this.Load += new EventHandler(this.VW_ZADUZENI_PARTNERIUserDataGrid_Load);
            ((ISupportInitialize) this.userControlDataGridVW_ZADUZENI_PARTNERI).EndInit();
            this.ResumeLayout(false);
        }

        private void VW_ZADUZENI_PARTNERIUserDataGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
        }

        private void VW_ZADUZENI_PARTNERIUserDataGrid_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode && this.FillAtStartup)
            {
                this.DataGrid.Fill();
            }
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
        public virtual VW_ZADUZENI_PARTNERIDataGrid DataGrid
        {
            get
            {
                return this.userControlDataGridVW_ZADUZENI_PARTNERI;
            }
            set
            {
                this.userControlDataGridVW_ZADUZENI_PARTNERI = value;
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

        [Category("Deklarit Work With "), Description("True= Fill at Startup. False= Not Fill"), DefaultValue(true)]
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

        [Category("Deklarit Work With "), DefaultValue(true)]
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

