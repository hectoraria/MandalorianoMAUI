using DAL;
using ENT;

namespace BL
{
    public class clsListadosBL
    {
        public static List<clsMision> obtenerListadoMisionesBL()
        {
            return clsListadosDAL.obtenerListadoMisionesDAL();
        }

        public static clsMision obtenerMisionPorIdBL(int idMision)
        {
            return clsListadosDAL.obtenerMisionPorIdDAL(idMision);
        }
    }
}
