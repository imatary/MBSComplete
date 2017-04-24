﻿namespace Placa
{
    using Deklarit.Data;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Data;
    using System.Threading;

    public class VRSTAOBUSTAVEDataReader : IDisposable
    {
        private ReadWriteCommand cmVRSTEOBUSTAVASelect5;
        private ReadWriteConnection connDefault;
        private IDbTransaction daCurrentTransaction;
        private DataStore dsDefault;
        private bool m_Closed;
        private bool m_Disposed;
        private IDataReader VRSTEOBUSTAVASelect5;

        protected void Cleanup()
        {
            this.dsDefault.Dispose();
        }

        public void Close()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            if (!this.m_Disposed)
            {
                this.m_Disposed = true;
                try
                {
                    if (!this.m_Closed && (this.VRSTEOBUSTAVASelect5 != null))
                    {
                        this.m_Closed = true;
                        this.VRSTEOBUSTAVASelect5.Close();
                    }
                }
                finally
                {
                    try
                    {
                        this.connDefault.Close();
                    }
                    finally
                    {
                        this.Cleanup();
                    }
                }
            }
        }

        private void init_reader()
        {
            this.Initialize();
            this.dsDefault = new DataStore(new SqlServer2005Handler(), "System.Data.SqlClient", Configuration.ConnectionString, DeklaritTransaction.TransactionSlotName);
            this.m_Disposed = false;
            this.m_Closed = true;
        }

        private void Initialize()
        {
            this.m_Disposed = false;
            this.m_Closed = false;
            if (this.Transaction == null)
            {
                this.Transaction = (IDbTransaction) Thread.GetData(Thread.GetNamedDataSlot(DeklaritTransaction.TransactionSlotName));
            }
        }

        public IDataReader Open()
        {
            this.init_reader();
            this.m_Closed = false;
            this.connDefault = this.dsDefault.GetReadWriteConnection(this.daCurrentTransaction);
            this.cmVRSTEOBUSTAVASelect5 = this.connDefault.GetCommand("SELECT TM1.[VRSTAOBUSTAVE], TM1.[NAZIVVRSTAOBUSTAVE] FROM [VRSTEOBUSTAVA] TM1 WITH (NOLOCK) ORDER BY TM1.[VRSTAOBUSTAVE] ", false);
            this.VRSTEOBUSTAVASelect5 = this.cmVRSTEOBUSTAVASelect5.ExecuteReader((CommandBehavior) Conversions.ToInteger(Interaction.IIf(this.daCurrentTransaction == null, Configuration.ReaderCommandBehavior, CommandBehavior.Default)));
            return this.VRSTEOBUSTAVASelect5;
        }

        public IDataReader OpenByVRSTAOBUSTAVE(short vRSTAOBUSTAVE)
        {
            this.init_reader();
            this.m_Closed = false;
            this.connDefault = this.dsDefault.GetReadWriteConnection(this.daCurrentTransaction);
            this.cmVRSTEOBUSTAVASelect5 = this.connDefault.GetCommand("SELECT TM1.[VRSTAOBUSTAVE], TM1.[NAZIVVRSTAOBUSTAVE] FROM [VRSTEOBUSTAVA] TM1 WITH (NOLOCK) WHERE TM1.[VRSTAOBUSTAVE] = @VRSTAOBUSTAVE ORDER BY TM1.[VRSTAOBUSTAVE] ", false);
            if (this.cmVRSTEOBUSTAVASelect5.IDbCommand.Parameters.Count == 0)
            {
                this.cmVRSTEOBUSTAVASelect5.IDbCommand.Parameters.Add(this.dsDefault.GetDbParameter("@VRSTAOBUSTAVE", DbType.Int16));
            }
            this.cmVRSTEOBUSTAVASelect5.SetParameter(0, vRSTAOBUSTAVE);
            this.VRSTEOBUSTAVASelect5 = this.cmVRSTEOBUSTAVASelect5.ExecuteReader((CommandBehavior) Conversions.ToInteger(Interaction.IIf(this.daCurrentTransaction == null, Configuration.ReaderCommandBehavior, CommandBehavior.Default)));
            return this.VRSTEOBUSTAVASelect5;
        }

        public IDbTransaction Transaction
        {
            get
            {
                return this.daCurrentTransaction;
            }
            set
            {
                this.daCurrentTransaction = value;
            }
        }
    }
}
