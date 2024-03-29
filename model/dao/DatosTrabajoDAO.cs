﻿
using SysCredito.model.db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysCredito.EntiteFramework;

namespace SysCredito.model.dao
{
    class DatosTrabajoDAO
    {
        public static void addTrabajo(centrotrabajo centrotrabajo)
        {
            using(FOCUSEntities db = new FOCUSEntities())
            {
                centrotrabajo.idcentrotrabajo = getTotalTrabajo() + 1;
                db.centrotrabajo.Add(centrotrabajo);
                db.SaveChanges();
            }
        }

        public static int getTotalTrabajo()
        {

            using (FOCUSEntities db = new FOCUSEntities())
            {
                return db.centrotrabajo.ToList().Count;
            }
        }
    }
}
