using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetAeroport.Models
{

    public class Vol
    {
        public string ID { get; set; }
        public string Origine { get; set; }
        public string Destination { get; set; }
        public string Etat { get; set; }
        public string Logo { get; set; }
        public string Prevu { get; set; }
        public string Revise { get; set; }
        public string Porte { get; set; }
        public DateTime Date { get; set; }
        public string TypeVol { get; set; }
        public string InstanceVol { get; set; }

        public Vol(string iD, string origine, string destination, string etat, string logo, string prevu, string revise, string porte, DateTime date, string typevol,string instancevol)
        {
            ID = iD;
            Origine = origine;
            Destination = destination;
            Etat = etat;
            Logo = logo;
            Prevu = prevu;
            Revise = revise;
            Porte = porte;
            Date = date;
            TypeVol = typevol;
            InstanceVol = instancevol;
        }

        public Vol()
        {
            ID = "";
            Origine = "";
            Destination = "";
            Etat = "";
            Logo = "";
            Prevu = "";
            Revise = "";
            Porte = "";
            Date = DateTime.Now;
            TypeVol = "";
            InstanceVol = "";
        }
        public static List<Vol> LoadFromDataSet(DataSet datas)
        {
            List<Vol> liste = new List<Vol>();
            Vol instance = new Vol();

            for (int i = 0; i < datas.Tables[0].Rows.Count; i++) {
                instance = new Vol();
                instance.ID = datas.Tables[0].Rows[i]["ID"].ToString();
                instance.Origine = datas.Tables[0].Rows[i]["ORIGINE"].ToString();
                instance.Destination = datas.Tables[0].Rows[i]["DESTINATION"].ToString();
                instance.Logo = datas.Tables[0].Rows[i]["LOGO"].ToString();
                instance.Porte = datas.Tables[0].Rows[i]["PORTE"].ToString();
                instance.TypeVol = datas.Tables[0].Rows[i]["TYPEVOL"].ToString();
                instance.Etat = datas.Tables[0].Rows[i]["ETAT"].ToString();
                instance.Prevu = datas.Tables[0].Rows[i]["PREVU"].ToString();
                instance.Revise = datas.Tables[0].Rows[i]["REVISE"].ToString();
                instance.Date =(DateTime)datas.Tables[0].Rows[i]["DATE"];
                instance.InstanceVol = datas.Tables[0].Rows[i]["instanceID"].ToString();

                liste.Add(instance);


            }

            return liste;

        }
      
    }
}