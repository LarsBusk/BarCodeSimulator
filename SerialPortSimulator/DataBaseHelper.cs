using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    private int GetNumberOfNormalSamples()
    {
      int numberOfSamples = 0;
      try
      {
        numberOfSamples = dataBaseAccessor.tblMfCdSamples.Count(f => f.SampleType == 0);
      }
      catch (Exception e)
      {
        MessageBox.Show("Failed to connect to SQL server.", "Error");
      }

      return numberOfSamples;
    }
  }
}
