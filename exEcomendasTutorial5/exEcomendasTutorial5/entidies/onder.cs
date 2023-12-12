using exEcomendasTutorial5.entidies.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exEcomendasTutorial5.entidies
{
    internal class onder
    {
        private DateTime moment;
        private OnderStatus onderStatus;
        private List<onderItem> listaEncomendas = new List<onderItem>();
        private Client client;

        public onder(DateTime moment, OnderStatus onderStatus, Client client)
        {
            this.moment = moment;
            this.onderStatus = onderStatus;
            this.client = client;
        }

        public void AddItem(onderItem onderitem)
        {
            listaEncomendas.Add(onderitem); 
            
        }
        public void RemoveItem(onderItem onderitem)
        {
            listaEncomendas.Remove(onderitem);
        }

        public double Total()
        {
            double vTotal = 0;
            foreach (onderItem item in listaEncomendas)
                vTotal += item.subtotal();
            return vTotal;
        }

        public override string ToString()
        {
            string descitem = "";
            foreach (onderItem item in listaEncomendas)
                descitem +="\n\t" + item.ToString();

            return $"Dados da encomenda:" +
                $"\n\tClinete: {client.ToString()}" +
                $"\n\tData/hora:{moment.ToLongDateString()} +" +
                $"{moment.ToLongTimeString()}" +
                $"Estado: {(OnderStatus)onderStatus}+  " +
                $"\n\n\t itens Encomendados: \n\t\t {descitem}";
        }
    } 
}
