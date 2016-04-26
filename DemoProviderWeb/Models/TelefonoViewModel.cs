using System;
using Microsoft.SharePoint.Client;

namespace DemoProviderWeb.Models
{
    public class TelefonoViewModel
    {
        public int Id { get; set; }

        public String Nombre { get; set; }

        public String Numero { get; set; }

        public static TelefonoViewModel FromListItem(ListItem item)
        {
            var data = new TelefonoViewModel();
            var id = item["ID"].ToString();
            int ido = 0;
            int.TryParse(id, out ido);
            data.Id = ido;
            data.Nombre = item["Title"].ToString();
            data.Numero = item["Numero"].ToString();
            return data;
        }
    }
}