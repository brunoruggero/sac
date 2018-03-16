using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCompra
    {

        //construtores
        public ModeloCompra()
        {
            this.ComCod = 0;
            this.ComData = DateTime.Now;
            this.ComNFiscal = 0;
            this.ComTotal = 0;
            this.ComNParcelas = 0;
            this.ComStatus = "Válida";
            this.ForCod = 0;
            this.TpaCod = 0;
        }

        public ModeloCompra(int comCod, DateTime data, int nFiscal, double total,
            int nParcelas, String status, int forCod, int tpaCod)
        {
            this.ComCod = comCod;
            this.ComData = data;
            this.ComNFiscal = nFiscal;
            this.ComTotal = total;
            this.ComNParcelas = nParcelas;
            this.ComStatus = status;
            this.ForCod = forCod;
            this.TpaCod = tpaCod;
        }

        //propriedades
        private int com_cod;

        public int ComCod
        {
            get
            {
                return this.com_cod;
            }
            set
            {
                this.com_cod = value;
            }
        }

        private DateTime com_data;

        public DateTime ComData
        {
            get { return this.com_data; }
            set { this.com_data = value; }
        }

        private int com_nfiscal;

        public int ComNFiscal
        {
            get { return this.com_nfiscal; }
            set { this.com_nfiscal = value; }
        }

        private Double com_total;

        public Double ComTotal
        {
            get { return this.com_total; }
            set { this.com_total = value; }
        }

        private int com_nparcelas;

        public int ComNParcelas
        {
            get { return this.com_nparcelas; }
            set { this.com_nparcelas = value; }
        }

        private String com_status;

        public String ComStatus
        {
            get { return this.com_status; }
            set { this.com_status = value; }

        }

        private int for_cod;

        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        private int tpa_cod;

        public int TpaCod
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }
    }
}
