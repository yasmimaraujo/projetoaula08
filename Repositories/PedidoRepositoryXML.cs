using ProjetoAula08.Entities;
using ProjetoAula08.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoAula08.Repositories
{
    public class PedidoRepositoryXML : IPedidoRepository
    {
        public void Exportar(Pedido pedido)
        {
            //Criando o nome do arquivo...
            var path = $"c:\\temp\\pedido_{pedido.Id}.xml";
            //Serializando os dados do objeto Pedido para XML.. 
            var xml = new XmlSerializer(pedido.GetType());
            //Gravar no arquivo
            using (var streamWriter = new StreamWriter(path))
            {
                xml.Serialize(streamWriter, pedido);
            }
        }
    }
}
