﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hayvan_Takip_Otomasyonu
{
    class sqlbaglantisi
    {

       public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\\Dosyalar\\HTO.mdf; Integrated Security = True");

            baglan.Open();
            return baglan;

        }
    }
}
