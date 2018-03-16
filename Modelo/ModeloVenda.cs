using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloVenda
    {
        //construtores
        public ModeloVenda()
        {
            this.VenCod = 0;
            this.VenData = DateTime.Now;
            this.VenNFiscal = 0;
            this.VenTotal = 0;
            this.VenNParcelas = 0;
            this.VenStatus = "Válida";
            this.CliCod = 0;
            this.TpaCod = 0;
            this.VenAvista = 0;
        }

        public ModeloVenda(int venCod, DateTime data, int nFiscal, double total,
            int nParcelas, String status, int cliCod, int tpaCod, int avista)
        {
            this.VenCod = venCod;
            this.VenData = data;
            this.VenNFiscal = nFiscal;
            this.VenTotal = total;
            this.VenNParcelas = nParcelas;
            this.VenStatus = status;
            this.CliCod = cliCod;
            this.TpaCod = tpaCod;
            this.VenAvista = avista;
        }

        //propriedades
        private int ven_cod;

        public int VenCod
        {
            get
            {
                return this.ven_cod;
            }
            set
            {
                this.ven_cod = value;
            }
        }

        private DateTime ven_data;

        public DateTime VenData
        {
            get { return this.ven_data; }
            set { this.ven_data = value; }
        }

        private int ven_nfiscal;

        public int VenNFiscal
        {
            get { return this.ven_nfiscal; }
            set { this.ven_nfiscal = value; }
        }

        private Double ven_total;

        public Double VenTotal
        {
            get { return this.ven_total; }
            set { this.ven_total = value; }
        }

        private int ven_nparcelas;

        public int VenNParcelas
        {
            get { return this.ven_nparcelas; }
            set { this.ven_nparcelas = value; }
        }

        private String ven_status;

        public String VenStatus
        {
            get { return this.ven_status; }
            set { this.ven_status = value; }

        }

        private int cli_cod;

        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        private int tpa_cod;

        public int TpaCod
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }

        private int ven_avista;

        public int VenAvista
        {
            get { return this.ven_avista; }
            set { this.ven_avista = value; }
        }
    }
}
