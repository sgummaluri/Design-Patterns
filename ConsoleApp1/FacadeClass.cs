namespace Facade
{
    public class FacadeClass
    {
        public string TurnOffComputerAndMonitor()
        {
            string strResult = string.Empty;
            TurnOffComputer turnOffComputer = new TurnOffComputer();
            strResult += turnOffComputer.SaveWork() + "\n";
            strResult += turnOffComputer.TurnOff() + "\n";

            TurnOffMonitor turnOffMonitor = new TurnOffMonitor();
            strResult += turnOffMonitor.TurnOff();

            return strResult;
        }
    }
}
