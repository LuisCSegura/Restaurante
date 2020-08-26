using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ReportesBOL
    {
        private ReportesDAL rdal = new ReportesDAL();

        public LinkedList<Reportes> primer_repor(DateTime fecha)
        {
            try
            {
                return rdal.primer_repo(fecha);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }


        public Reportes Segundo_repor(DateTime fecha)
        {
            try
            {
                return rdal.Segundo_repo(fecha);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }


        public Reportes Tercer_repor(DateTime fecha)
        {
            try
            {
                return rdal.Tercer_repo(fecha);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }



        public Reportes Cuarto_repor(DateTime fecha)
        {
            try
            {
                return rdal.Cuarto_repo(fecha);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }



        public Reportes Quinto_repor(DateTime fecha)
        {
            try
            {
                return rdal.Quinto_repo(fecha);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }



        public Reportes Sexto_repor(DateTime fecha)
        {
            try
            {
                return rdal.Sexto_repo(fecha);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }



        public LinkedList<Reportes> Setimo_repor(DateTime fecha)
        {
            try
            {
                return rdal.Setimo_repo(fecha);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }

        public LinkedList<Reportes> Octavo_repor(DateTime fecha)
        {
            try
            {
                return rdal.Octavo_repo(fecha);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }


        public LinkedList<Reportes> Noveno_repor(DateTime fecha)
        {
            try
            {
                return rdal.Noveno_repo(fecha);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }



        }




    }
}
