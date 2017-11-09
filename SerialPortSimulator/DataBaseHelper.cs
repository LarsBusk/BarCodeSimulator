using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortSimulator
{
  public class DataBaseHelper
  {
    private MeatMasterDataBaseAccessorDataContext dataBaseAccessor;

    private int numberOfSamples;

    public DataBaseHelper()
    {
      dataBaseAccessor = new MeatMasterDataBaseAccessorDataContext();
      numberOfSamples = GetNumberOfNormalSamples();
    }
    public int GetNumberOfNormalSamples()
    {
      return dataBaseAccessor.tblMfCdSamples.Count(f => f.SampleType == 0);
    }

    public bool NewSample()
    {
      int currentNumberOfSamples = GetNumberOfNormalSamples();

      if (numberOfSamples < currentNumberOfSamples)
      {
        numberOfSamples = currentNumberOfSamples;
        return true;
      }

      return false;
    }
  }
}
