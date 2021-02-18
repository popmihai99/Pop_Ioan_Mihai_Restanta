using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pop_Mihai_Lab.Models
{
    public class Comanda
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int ProdusID { get; set; }
        public Produs Produs{get;set;}
        public int NrProduse { get; set; }
    }
}
