using Repository.Model;
using Repository.Service;
namespace Repository.Servcie
{
    public class ProvinceService : ServiceBase<Province>
    {
        public bool AddManyProvinces(List<string> provinceNames)
        {
            try
            {
                // Convert province names to Province entities
                var provinces = provinceNames.ConvertAll(name => new Province { ProvinceName = name });

                // Call the AddMany method from the base class
                return AddMany(provinces);
            }
            catch
            {
                // Handle exception or log it
                return false;
            }
        }
    }
}
